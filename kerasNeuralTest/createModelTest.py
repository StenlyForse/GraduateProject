import pandas as pd
from keras.layers import Dense
from keras.models import Sequential
import pyodbc as odbc
import time
import sys

serverName = sys.argv[1]
databaseName = sys.argv[2]

projectNumber = sys.argv[3]
sampleNumber = sys.argv[4]

conn = odbc.connect('Driver={SQL Server};'
                    'Server='+serverName+ ';'
                    'Database='+databaseName+ ';'
                    'Trusted_Connection=yes;')

#получаем данные
#выполнение запроса с помощью pandas, тут надо в конце указать переменную для подключения(conn)
data = pd.read_sql_query('SELECT InputValue, OutputValue FROM dbo.DataSample WHERE "SampleNumber" ={}'.format(int(sampleNumber)), conn)

values = data['InputValue'].to_list()
all_y_trues = data['OutputValue'].to_list()
#print(val)
#print(vol)

# модель - последовательная (полносвязная)
model = Sequential()
# входной слой
model.add(Dense(1, input_dim=1, activation='sigmoid'))
# внутренний слой
model.add(Dense(3, activation='sigmoid'))
model.add(Dense(2, activation='sigmoid'))
# выходной слой
model.add(Dense(1, activation='sigmoid'))
# сборка модели
model.compile(loss='mse', optimizer='adam')

# обучаем нейронку: (обучающий датасет, обучаеющие значения аномалий, количество эпох, количество данных за 1 раз)
model.fit(x=values, y=all_y_trues, epochs=300, batch_size=1)

modelName = 'model'+projectNumber+''+sampleNumber+'.h5'
#сохраняем модель
model.save(''+modelName+'')
#инициализируем курсор
cursor = conn.cursor()
#cursor.execute('INSERT INTO dbo.Model(ModelNumber, ProjectNumber, ModelName) values ('+sampleNumber+', '+projectNumber+', ['+modelName+']) ')
cursor.execute('''INSERT INTO dbo.Model(ModelNumber, ProjectNumber, ModelName) values (?, ?, ?)''',(sampleNumber,projectNumber,modelName))
conn.commit()
print('Модель успешно создана')


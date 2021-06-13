import pandas as pd
from keras.layers import Dense
from keras.models import Sequential
# получение набора данных
par = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Обучение')
data = par['Value'].to_list()
all_y_trues = par['Anomaly'].to_list()

workingData = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Work')
work = workingData['Values']


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
model.fit(x=data, y=all_y_trues, epochs=300, batch_size=1)

print('Сохранение модели')
#model.save('model.h5')
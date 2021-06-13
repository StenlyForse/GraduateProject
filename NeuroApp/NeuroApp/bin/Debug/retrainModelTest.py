from keras.models import load_model
import sys
import pyodbc as odbc
from pathlib import Path
import pandas as pd

#имя сервера и БД
serverName = sys.argv[1]
databaseName = sys.argv[2]

#имя проекта, выборки и модели
sampleNumber = sys.argv[3]
modelName = sys.argv[4]

#aaa = 149
conn = odbc.connect('Driver={SQL Server};'
                    'Server='+serverName+ ';'
                    'Database='+databaseName+ ';'
                    'Trusted_Connection=yes;')

cursor = conn.cursor()

#текущая рабочая папка(из которой запускается проект)
curworkdir = Path.cwd()

#modelName = cursor.execute('SELECT ModelName FROM dbo.Model WHERE ProjectNumber='+projectNumber+' AND ModelNumber='+modelNumber+'').fetchval()
model = l

data = pd.read_sql_query('SELECT InputValue, OutputValue FROM dbo.DataSample WHERE "SampleNumber" ={}'.format(int(sampleNumber)), conn)
oad_model(str(curworkdir)+'\\'+modelName)
values = data['InputValue'].to_list()
all_y_trues = data['OutputValue'].to_list()

model.fit(x=values, y=all_y_trues, epochs=100, batch_size=1)

model.save(modelName)

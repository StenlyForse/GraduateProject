from keras.models import load_model
import sys
import pyodbc as odbc
from pathlib import Path

serverName = sys.argv[1]
databaseName = sys.argv[2]

projectNumber = sys.argv[3]
modelNumber = sys.argv[4]

testValue = 149
conn = odbc.connect('Driver={SQL Server};'
                    'Server='+serverName+ ';'
                    'Database='+databaseName+ ';'
                    'Trusted_Connection=yes;')

cursor = conn.cursor()

#текущая рабочая папка(из которой запускается проект)
curworkdir = Path.cwd()

modelName = cursor.execute('SELECT ModelName FROM dbo.Model WHERE ProjectNumber='+projectNumber+' AND ModelNumber='+modelNumber+'').fetchval()
model = load_model(str(curworkdir)+'\\'+modelName)
#делаем предикт(нужен для того, чтобы результат работы был длинее нуля)
pred = model.predict([testValue])
print(pred)


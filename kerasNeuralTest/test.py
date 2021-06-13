import numpy as np
import sys

#first = sys.argv[1]
#second = sys.argv[2]
#stringOk = sys.argv[3]

#third = int(first)+int(second)
#strstr = stringOk*5

#print("First arg: ", first)
#print("Second arg: ", second)
#print("Sum of 2 arg: ", third)
#print("Your string miltiplied on 5: ", strstr)


num = input()
number = input()
strok = 'model'+num+''+number
#strok = strok + number
print(strok)

from keras.models import load_model
import sys
import pyodbc as odbc
from pathlib import Path
import pandas as pd
from keras.layers import Dense
from keras.models import Sequential

serverName = 'LAPTOP-0O3M29HG\SQLEXPRESS'
databaseName = 'NeuroApp'

projectNumber = '1'
modelNumber = '1'

sampleNumber = 1

aaa = 149
conn = odbc.connect('Driver={SQL Server};'
                    'Server='+serverName+ ';'
                    'Database='+databaseName+ ';'
                    'Trusted_Connection=yes;')

cursor = conn.cursor()

#текущая рабочая папка(из которой запускается проект)
curworkdir = Path.cwd()

modelName = cursor.execute('SELECT ModelName FROM dbo.Model WHERE ProjectNumber='+projectNumber+' AND ModelNumber='+modelNumber+'').fetchval()
model = load_model(str(curworkdir)+'\\'+modelName)

data = pd.read_sql_query('SELECT InputValue, OutputValue FROM dbo.DataSample WHERE "SampleNumber" ={}'.format(int(sampleNumber)), conn)

values = data['InputValue'].to_list()
all_y_trues = data['OutputValue'].to_list()

model.fit(x=values, y=all_y_trues, epochs=100, batch_size=1)

model.save(modelName)

import pyodbc as odbc
import sys
from keras.models import load_model
from pathlib import Path

serverName = sys.argv[1] #'LAPTOP-0O3M29HG\SQLEXPRESS'
databaseName = sys.argv[2] #'NeuroApp'
modelName = sys.argv[3] #'model11.h5'
maxID = sys.argv[4]
prevID = sys.argv[5]

prevID = int(prevID)
maxID = int(maxID)
conn = odbc.connect('Driver={SQL Server};'
                    'Server='+serverName+ ';'
                    'Database='+databaseName+ ';'
                    'Trusted_Connection=yes;')
# подключение курсора (хз зачем)
cursor = conn.cursor()

#текущая рабочая папка(из которой запускается проект)
curworkdir = Path.cwd()
model = load_model(str(curworkdir)+'\\'+modelName)


#stroka=cursor.execute('SELECT ID,ProjectNumber,PointAndParamName,DateTime,Value from dbo.Data where "ID" ={}'.format(idVal)).fetchval()
#stroka=cursor.execute('SELECT ID,ProjectNumber,PointAndParamName,DateTime,Value from dbo.Data where "ID" ='+str(idVal)+'').fetchall()
#print(stroka)

while prevID < maxID:
    # получаем одинчное значение
    singleValue=cursor.execute('SELECT Value from dbo.Data where "ID" ={}'.format(prevID)).fetchval()
    #print(singleValue)
    predict = model.predict([int(singleValue)])
    #print(predict)
    if (predict < 0.6):
        #копирование целой строки в FilteredData, что значит то, что аномалий нет
        cursor.execute('INSERT INTO dbo.FilteredData (ProjectNumber,PointAndParamName,DateTime,Value) SELECT ProjectNumber,PointAndParamName,DateTime,Value FROM dbo.Data WHERE ID='+str(prevID)+'')
        conn.commit()
        print('отправлено в базу FILTERED {}',format(prevID))
    else:
        cursor.execute('INSERT INTO dbo.AnomalyData (ProjectNumber,PointAndParamName,DateTime,Value) SELECT ProjectNumber,PointAndParamName,DateTime,Value FROM dbo.Data WHERE ID=' + str(prevID) + '')
        conn.commit()
        print('отправлено в базу ANOMALY {}',format(prevID))
    prevID = prevID + 1

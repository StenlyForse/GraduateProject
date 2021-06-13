import pyodbc as odbc
import pandas as pd
import time
import sys

serverName = 'LAPTOP-0O3M29HG\SQLEXPRESS'
databaseName = 'NeuroApp'

#serverName1 = sys.argv[1]
#databaseName1 = sys.argv[2]
idVal = 8
#подключение к БД
#conn = odbc.connect('Driver={SQL Server};'
#                    'Server=LAPTOP-0O3M29HG\SQLEXPRESS;'
#                    'Database=NeuroApp;'
#                    'Trusted_Connection=yes;')

conn = odbc.connect('Driver={SQL Server};'
                    'Server='+serverName+ ';'
                    'Database='+databaseName+ ';'
                    'Trusted_Connection=yes;')
#подключение курсора (хз зачем)
cursor = conn.cursor()
#выполнение запроса
cursor.execute('SELECT ID,ProjectNumber,PointAndParamName,DateTime,Value FROM dbo.Data')
#cursor.execute('SELECT PointAndParamName FROM dbo.Data')

#вывод значений из БД
for row in cursor:
    print(row)

cursor.execute('SELECT Value FROM dbo.Data')
#заносит полученные данные в список, но не подходящий для обработки с помощью нейронной сети
abc = list(cursor.fetchall())
print(abc)
result = [list(i) for i in abc]
print(result)

print('Now its pandas')
#выполнение запроса с помощью pandas, тут надо в конце указать переменную для подключения(conn)
sql_query = pd.read_sql_query('SELECT Value FROM dbo.Data', conn)
print(sql_query)
values = sql_query['Value'].to_list()
print(values)

#получаем одинчное значение
singleValue=cursor.execute('SELECT Value from dbo.Data where "ID" ={}'.format(idVal)).fetchval()
print("Одиночное значение")
print(singleValue)

#получаем максимальный ID
maxId=cursor.execute('SELECT MAX(ID) FROM dbo.Data').fetchval()

print("Максимальное ID")
print(maxId)
maxIDPrev=maxId
#конструкция, которая раз в секунду проверяет, появился ли новый айдишник и если появился, выводит строку и затем обновляет максимальное значение айдишника - то есть это способ постоянно анализировать данные
while False:
    maxId = cursor.execute('SELECT MAX(ID) FROM dbo.Data').fetchval()
    if (maxId>maxIDPrev):
        query='SELECT * from dbo.Data where "ID" ={}'.format(maxId)
        cursor.execute(query)
        for row in cursor:
            print(row)
        maxIDPrev = maxId
    time.sleep(1)
#надо будет потом сюда подкрутить анализ значения на аномальность


#print("Процедура записи в БД")
#cursor.execute("INSERT INTO dbo.data(ProjectNumber, PointAndParamName, DateTime, Value) values (1, 'Переходный.ЦТП.тест2', '20201026 13:54:00.0000', 105.0143) ")
#conn.commit()
#print("Процедура записи в БД, попытка 2")
#cursor.execute('INSERT INTO dbo.data(ProjectNumber, PointAndParamName, DateTime, Value) values (1, \'Переходный.ЦТП.тест2.попытка 2\', \'20201026 13:56:00.0000\', 102.0143)')
#conn.commit()


#забор с БД и превращение в датафрейм(лист) для кераса
#sampleNumber = 1
#values = pd.read_sql_query('SELECT InputValue, OutputValue FROM dbo.DataSample WHERE "SampleNumber" ={}'.format(int(sampleNumber)), conn)
#print(values)

#val = values['InputValue'].to_list()
#vol = values['OutputValue'].to_list()
#print(val)
#print(vol)

modName = cursor.execute('SELECT ModelName FROM dbo.Model WHERE ModelNumber=1 AND ProjectNumber=1').fetchval()
print(modName)
print(type(modName))
print(type(cursor))
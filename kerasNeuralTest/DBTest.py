import pyodbc as odbc
import pandas as pd
import time
import sys

#serverName = 'LAPTOP-0O3M29HG\SQLEXPRESS'
#databaseName = 'NeuroApp'

serverName = sys.argv[1]
databaseName = sys.argv[2]
#idVal = 8

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

#получаем максимальный ID
maxId=cursor.execute('SELECT MAX(ID) FROM dbo.Data').fetchval()

#print("Максимальное ID")
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


import pyodbc as odbc
import sys

serverName = sys.argv[1]
databaseName = sys.argv[2]

conn = odbc.connect('Driver={SQL Server};'
                    'Server='+serverName+ ';'
                    'Database='+databaseName+ ';'
                    'Trusted_Connection=yes;')

cursor = conn.cursor()

maxId = cursor.execute('SELECT MAX(ID) FROM dbo.Data').fetchval()

print(maxId)
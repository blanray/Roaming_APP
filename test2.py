import tkinter as tkr

import pyodbc

conn = pyodbc.connect(r'Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=E:\Roaming_APP\Database1.accdb;')
cursor = conn.cursor()
cursor.execute('select * from Empleados, Tabla1 where Edad > 10 and Edad < 100 and Nomre = Nombre')
   
for row in cursor.fetchall():
    print (row)

#columns = cursor.description

#print (columns)

cursor.execute('drop table Prueba')
cursor.commit

cursor.execute('create table Prueba (Campo1 number)')
cursor.commit()
cursor.execute('insert into Prueba values(2)')
cursor.commit()
cursor.execute('insert into Prueba values(7)')
cursor.commit()

cursor.execute('select * from Prueba')
   
for row in cursor.fetchall():
    print (row)

cursor.close()

cursor = None

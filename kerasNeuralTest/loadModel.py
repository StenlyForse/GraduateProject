import pandas as pd
from keras.models import load_model
import sys
from pathlib import Path

valueFromCS = 120#sys.argv[1]

#текущая рабочая папка из которой запускается процесс
curworkdir = Path.cwd()

print(curworkdir)


workingData = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Work')
work = workingData['Values']

print('Загрузка модели')
#r необходима для того, чтобы шарп не ругался на юникодовые конструкции
#model = load_model(r'C:\Users\Alex\PycharmProjects\kerasNeuralTest\model.h5')
#model = load_model(str(curworkdir)+'\model21.h5')
model = load_model(r'C:\Users\Alex\source\repos\NeuroApp\NeuroApp\bin\Debug\model21.h5')
predict = model.predict(work)
predict1 = model.predict([int(valueFromCS)])
print("Value from C#: ",predict1)

for i in range(len(work)):
    #predictedValue = model.predict(work[i])
    print("Элемент:", i, work[i], predict[i], sep='\t')

#predict1 = model.predict([200])
#print(predict1)
#predict1 = model.predict([2])
#print(predict1)
#predict1 = model.predict([0])
#print(predict1)

if (predict1 > 0.31):
    print('bolshe 0.31')
else:
    print('menshe 0.31')
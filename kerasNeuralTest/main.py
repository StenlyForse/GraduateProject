import pandas as pd
from keras.layers import Dense
from keras.models import Sequential
#from DB import singleValue
#импортирует другой скрипт сюда
#import DB



def print_hi(name):
    # Use a breakpoint in the code line below to debug your script.
    print(f'Hi, {name}')  # Press Ctrl+F8 to toggle the breakpoint.

# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print_hi('PyCharm')

# See PyCharm help at https://www.jetbrains.com/help/pycharm/

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
# scores = model.evaluate(data, all_y_trues)
# print("ааа"  f'{(scores*100):.3f}', sep='\t')
# print(len(work))

# предсказание аномальности
predict = model.predict(work)
# print(len(predict))
# print(predict)

# выводим значения аномалий с вероятностью их аномальности
for i in range(len(work)):
    #   predictedValue = model.predict(work[i])
    print("Элемент:", i, work[i], predict[i], sep='\t')

#получение значения из другого скрипта(DB)
#при этом изначально выполняется весь скрипт
#popen = Popen("DB.py SingleValue", stdout=PIPE, shell=True)
#print(str(popen, 'utf-8'))


#predict1 = model.predict([singleValue])

#print("Value from C#: ",predict1)

# predicted = model.predict([30])
# for i in range(len(work)):
# print("Вероятность аномальности I00: %.3f" % network.feedforward(i))
# print("Элемент:", i, work[i],  f'{model.predict(work[i]):.3f}', sep='\t')

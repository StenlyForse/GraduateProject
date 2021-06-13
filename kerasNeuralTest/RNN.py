import pandas as pd
from keras.layers import Dense, LSTM, Embedding
from keras.models import Sequential
from sklearn import preprocessing as pre


def print_hi(name):
    # Use a breakpoint in the code line below to debug your script.
    print(f'Hi, {name}')  # Press Ctrl+F8 to toggle the breakpoint.


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print_hi('PyCharm')

# See PyCharm help at https://www.jetbrains.com/help/pycharm/

# получение набора данных
#par = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Обучение')
#data = par['Value'].to_list()
#all_y_trues = par['Anomaly'].to_list()

#workingData = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Work')
#work = workingData['Values']


#добавление IDшников
#par = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Обучение')
par = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Обучение new')
smallData = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Обучение small')

print(par.head(10))

#data = par['Value'].to_list()
#all_y_trues = par['Anomaly'].to_list()
value1 = par['Value1'].to_list()
value2 = par['Value2'].to_list()
value3 = par['Value3'].to_list()
value4 = smallData['Value1'].to_list()

print(value1)

valueList = pd.DataFrame({'col1' : value1})
valueList['col2'] = value2
valueList['col3'] = value3
valueList = valueList.values.tolist()
print(valueList)
#здесь происходит нормализация данных
normalized_list = pre.normalize(valueList)
normalized_list = normalized_list.tolist()
print(normalized_list)

anomaly1 = par['Anomaly1'].to_list()
anomaly2 = par['Anomaly2'].to_list()
anomaly3 = par['Anomaly3'].to_list()
anomaly4 = smallData['Anomaly1'].to_list()

anomalyList = pd.DataFrame({'col1' : anomaly1})
anomalyList['col2'] = anomaly2
anomalyList['col3'] = anomaly3
anomalyList = anomalyList.values.tolist()

#workingData = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Work')
workingData = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Work new')
bigworkingData = pd.read_excel(r'C:\Users\Alex\Desktop\Реферат\Зиннур\данные\Testing Measurements.xlsx', sheet_name='Work big')
#work = workingData['Values']
work1 = workingData['Values1']
work2 = workingData['Values2']
work3 = workingData['Values3']
work4 = bigworkingData['Values0']

workList = pd.DataFrame({'col1' : work1})
workList['col2'] = work2
workList['col3'] = work3
workList = workList.values.tolist()




# модель - последовательная (полносвязная)
model = Sequential()
# входной слой
# Добавим слой Embedding ожидая на входе словарь размера 384, и
# на выходе вложение размерностью 64.
#model.add(Embedding(input_dim=384, output_dim=64)) рабочая фигня
#model.add(LSTM(1, input_dim=1, return_sequences=True))

#преобразование в один список, учебные данные
#df = pd.DataFrame({'col1': IDs})
#df['col2'] = data
#print(df)
#df = df.values.tolist()
#print(df)

#преобразование в один список, рабочие данные
#workDF = pd.DataFrame({'col1' :WorkID})
#workDF['col2'] = work
#workDF = workDF.values.tolist()
#print(workDF)

# тестирование добавления IDшников
#model.add(Embedding(input_dim=399, output_dim=64))
#model.add(LSTM(2, input_dim=2, return_sequences=True))
model.add(Dense(1, input_dim=1, activation='sigmoid'))
# внутренний слой
model.add(Dense(2))
model.add(Dense(3))
#model.add(LSTM(5, input_shape=(1, 5)))
#model.add(LSTM(5))
# выходной слой
model.add(Dense(1, activation='sigmoid'))
# сборка модели
model.compile(loss='mse', optimizer='adam')

# обучаем нейронку: (обучающий датасет, обучаеющие значения аномалий, количество эпох, количество данных за 1 раз)
model.fit(value4, anomaly4, epochs=100, batch_size=1)

# scores = model.evaluate(data, all_y_trues)
# print("ааа"  f'{(scores*100):.3f}', sep='\t')
# print(len(work))

# предсказание аномальности
predict = model.predict(work4)
# print(len(predict))
# print(predict)

# выводим значения аномалий с вероятностью их аномальности
for i in range(len(work4)):
    #   predictedValue = model.predict(work[i])
    print("Элемент:", i, work4[i], predict[i], sep='\t')

# predicted = model.predict([30])
# for i in range(len(work)):
# print("Вероятность аномальности I00: %.3f" % network.feedforward(i))
# print("Элемент:", i, work[i],  f'{model.predict(work[i]):.3f}', sep='\t')
#for f in range (30):
#    predicted = model.predict([f])
#    print(f, predicted, sep='\t')



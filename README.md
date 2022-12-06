## Урок 1. Знакомство с языком программирования C#
---------------------------------------------------
### Первые шаги написания программы

- Получить задачу
- Обдумать условие
- Уточнить условие
- Составить алгоритм
- Уточнить алгоритм
- Исправить алгоритм
- Перепроверить алгоритм
- Начать писать писать код, но это не точно

Создать новый проект C#

    $ dotnet new console

Запустить проект

    $ dotnet run

`Через Console мы обращаемся к системному
терминалу`

### Синтаксис

> `Write();` Вывод в одну строку

> `WriteLine();` В конце перейти на новую строку

> `ReadLine();` Считать строку из терминала

> `new Random().Next(min, max);` даст случайное целое число от min до max-1 [min, max-1] или [min, max)

#### **Типы данных**

|Тип данных|Диапазон                           |Размер                            |
|----------|-----------------------------------|----------------------------------|
|int       |От -2 147 483 648 до 2 147 483 647 |От -2 147 483 648 до 2 147 483 647|
|double    |от ±5,0 × 10−324 до ±1,7 × 10308   |64-разрядное целое число со знаком|
|string    |от 0 до много символов             |от 4 байт до 2 гб                 |
|bool      |true и false                       |1 байт                            |



Пример с Машой

```mermaid
flowchart TD
    1([Start]) --> 2[/"Ввод username"/]
	2 --> 3{"username == Маша"}
	3 --> |yes| 4("Вывод: Ура, это же МАША!")
	3 --> |no| 5("Вывод: Привет, username")
	4 --> 6(["finish"])
	5 --> 6
```
## Урок 2. Знакомство с функциями и массивами
---------------------------------------------------
### Функции в программировании

$f(x) = x^2 + 1$

$y = x^2 + 1$

$f(5) = 5^2 + 1$

$f(5) = 26$

$(1^2 + 1) + (2^2 + 1) + (3^2 + 1) + (4^2 + 1) + (5^2 + 1)$

$f(1) + f(2) + f(3) + f(4) + f(5)$

$\displaystyle\sum_{k=0}^5ƒ(k)$

	$ double f(double x)
	{
	double result = x * x + 1;
	return result
	}

	ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ... ])
	{
	Тело Метода
	return ЗначениеСоответствующееВозвращаемомуТипуДанных;
	}

### В начале было “стихийно”

	// Первый вариант поиска максимального значения
	Write("Введите значение: ");
	int a = ToInt32(ReadLine());
	Write("Введите значение: ");
	int b = ToInt32(ReadLine());
	Write("Введите значение: ");
	int c = ToInt32(ReadLine());
	Write("Введите значение: ");
	int d = ToInt32(ReadLine());
	Write("Введите значение: ");
	int e = ToInt32(ReadLine());
	Write("Введите значение: ");
	int f = ToInt32(ReadLine());
	Write("Введите значение: ");
	int g = ToInt32(ReadLine());
	Write("Введите значение: ");
	int h = ToInt32(ReadLine());
	Write("Введите значение: ");
	int i = ToInt32(ReadLine());

	int max = 0;

	if (max > a) max = a;
	if (max > b) max = b;
	if (max > c) max = c;
	if (max > d) max = d;
	if (max > e) max = e;
	if (max > f) max = f;
	if (max > g) max = g;
	if (max > h) max = h;
	if (max > i) max = i;
----------------------------------

	// Второй вариант кода максимального значения
	int Max(int arg1, int arg2, int arg3);
	{
		int result = 0;
		if (arg1 > result) result = arg1;
		if (arg2 > result) result = arg2;
		if (arg3 > result) result = arg3;
		return result;
	}
	int GetData()
	{
		Write("Введите значение: ");
		return ToInt32(ReadLine());
	}

	int a = GetData();
	int b = GetData();
	int c = GetData();
	int d = GetData();
	int e = GetData();
	int f = GetData();
	int g = GetData();
	int h = GetData();
	int i = GetData();

	int max = Max(
			Max(a, b, c),
			Max(d, e, f),
			Max(g, h, i));

	int max = Max(max);
	
--------------------------

	// Третьи вариант кода поиска максимального значения
	int Max(int arg1, int arg2, int arg3);
	{
		int result = 0;
		if (arg1 > result) result = arg1;
		if (arg2 > result) result = arg2;
		if (arg3 > result) result = arg3;
		return result;
	}
	int GetData()
	{
		Write("Введите значение: ");
		return ToInt32(ReadLine());
	}
	int max = Max(
				  Max(GetData(), GetData(), GetData()),
				  Max(GetData(), GetData(), GetData()),
				  Max(GetData(), GetData(), GetData()),
				);

-------------------------------------------------------

Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
1. Установить счетчик index в позицию 0
2. Если array [index] = find, алгоритм завершил работу успешно.
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.
___________________________________________________

	int[] array = {1, 12, 31, 4, 15, 16, 17, 18};
	int n = array.Lenght;
	int find = 4;

	int index = 0;

	while (index < n)
	{
		if (array[index] == find)
		{
			Console.WriteLIne(index);
			break;
		}
		index++;
	}

---------------------------------------

	void FillArray(int[] collection)
	{
		int lenght = collection.Lenght;
		int index = 0;
		while (index < lenght)
		{
			collection[index] = new Random().Next(1, 10);
			index++;
		}
	}

	void PrintArray(int[] col)
	{
		int count = col.Lenght;
		int position = 0;
		while (position < count)
		{
			Console.WriteLine(col[position]);
			position++;
		}
	}

	int[] array = new int[10];

	FillArray(array);
	PrintArray(array);


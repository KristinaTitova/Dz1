string[] inputArray = { "привет", "2", "мир", ":-)", "1234", "1567" };

// Метод печати массива
строка printArray(строка[] inputArray)
{
 возвращает строку.Присоединиться(", ", inputArray);
}

// Метод подсчета строк в массиве длиной менее или равной 3 символам
int CountStringInArray(ввод строки[])
{
 int len = входной массив.Длина;
 количество чисел = 0;
 int maxLengthString = 3;
 для (int i = 0; i < len; i ++)
    {
 если (inputArray[i].Длина <= maxLengthString)
        {
 количество++;
        }
    }
 количество возвращаемых данных;
}

// Метод создания нового массива из строк, меньших или равных 3 символам, которые он находит во входном массиве
// ! передайте результат метода CountStringInArray в аргумент countWords !
строка[] CreateNewArray(строка[] inputArray, количество слов int)
{
 int len = входной массив.Длина;
 строка[] OutputArray = новая строка[количество слов];
 количество чисел = 0;
 int maxLengthString = 3;
 для (int i = 0; i < len; i ++)
    {
 если (inputArray[i].Длина <= maxLengthString)
        {
 OutputArray[количество] = inputArray[i];
 количество++;
        }
    }

 возвращает OutputArray;
}

printArray(входной массив);

строка[] OutputArray = CreateNewArray(входной массив, CountStringInArray(входной массив));

printArray(выходной массив);
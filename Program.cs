class Program
{
    static void Main()
    {
        // Задаем исходный массив строк
        string[] originalArray = { "Hello", "World", "C#", "is", "cool" };

        // Формируем новый массив из строк, длина которых меньше или равна 3 символам
        string[] newArray = FilterArray(originalArray);

        // Выводим новый массив на экран
        Console.WriteLine("Новый массив:");
        foreach (string item in newArray)
        {
            Console.WriteLine(item);
        }
    }

    // Метод для фильтрации массива строк
    static string[] FilterArray(string[] inputArray)
    {
        // Считаем количество строк, подходящих под условие
        int count = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] resultArray = new string[count];

        // Заполняем новый массив подходящими строками
        int index = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                resultArray[index] = item;
                index++;
            }
        }

        return resultArray;
    }
}
/* Написать программму, которая из имеющегося массива строк
 формирует массив строк, длина которых меньше либо равна 3 символа.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.WriteLine("Ведите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] firstArray = new string[n];
string[] resultArray = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Введите элемент: ");
    firstArray[i] = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        if (firstArray[i].Length <= 3)
        {
            resultArray[i] = firstArray[i];
        }
    }
}
Console.WriteLine("Начальный массив: [" + string.Join(" ", firstArray) + "]");
Console.WriteLine("Конечный массив: [" + string.Join(" ", resultArray) + "]");
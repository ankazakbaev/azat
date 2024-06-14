/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] array = {"34325", "1567", "-2","com"};
string[] array2 = new string[array.Length];

void CutArray (string[] array, string[] array2) 
{ int count = 0;
  for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <=3)
    {
    array2[count] = array[i];
    count++;
    }
    
}
}
CutArray(array, array2);

void PrintArray(string[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write($"{num[i]} ");
    }

}
Console.WriteLine();

PrintArray(array2);



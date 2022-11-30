// Напишите программу,
// которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

Console.Write("Введите количество элементов в массиве N: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заполните массив ");
string [] input = new string [n];
for (int i = 0; i < input.Length; i++)
{
    input[i]=Console.ReadLine();
}
Console.Write("Изначальный массив: ");
Console.Write("|");
for (int i = 0; i < input.Length; i++)
{
    if (i < input.Length - 1) Console.Write($"{input[i]},");
    else Console.Write($"{input[i]}");
}
Console.WriteLine("|");

int k=3;
int count =0 ;
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length<=k) count++;
}

string [] output = new string [count];

for (int i = 0, j=0; i < input.Length; i++)
{
    if (input[i].Length<=k)
    {
        output[j]=input[i];
        j++;
    }
}

Console.Write("Итоговый массив: ");
Console.Write("|");
for (int i = 0; i < output.Length; i++)
{
    if (i < output.Length - 1) Console.Write($"{output[i]},");
    else Console.Write($"{output[i]}");
}
Console.WriteLine("|");
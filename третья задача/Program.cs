// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("введите цифру от 1 до 7: ");
int N = int.Parse(Console.ReadLine());
string[]array={"введите цифру от 1 до 7", "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
int index = N;
if (index < 8 && index > 0)
{
    Console.WriteLine(array[index]);
}
 else
 {
    Console.WriteLine("введенное значение не входит в диапазон от 1 до 7");
 } 
  
if (index > 5 )
    {
        Console.WriteLine("Урра!выходной!");
    }
    else
    {
        Console.WriteLine("рабочий день");
    }

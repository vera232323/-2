Console.WriteLine("Пиши первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пиши второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пиши третье число");
int c = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    if(a>c)
{
    Console.WriteLine(a + " "+ "- наибольшее число");
}
else
{
    Console.WriteLine(c + " "+ "- наибольшее число");
}
}
else
{
    if(b>c)
    {
      Console.WriteLine(b + " "+ " - наибольшее число");  
    }
    else
    {
        Console.WriteLine(c + " "+ " - наибольшее число"); 
    }
}
int num1;
Console.WriteLine("Введите число");
num1 = Convert.ToInt32(Console.ReadLine());
string name = num1.ToString();
char[] charArray = name.ToCharArray();
 if (num1>99) 
     {
    char first = charArray[2]; 
     Console.WriteLine(first);
     }
 else Console.WriteLine("Третье число отсутствует.");

Console.Write("Введите трехзначное число: ");
int i=Convert.ToInt32(Console.ReadLine());
int i1=i/100;
int i2=i/10;
int i3=i2-(i1*10);
Console.WriteLine(i3);
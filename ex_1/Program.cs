Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень");
int x = Convert.ToInt32(Console.ReadLine());
int res = 0;
res = (int)Math.Pow(n, x);
Console.WriteLine(res);
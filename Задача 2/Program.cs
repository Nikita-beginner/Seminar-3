Console.Write("Введите номер переменной X первой точки => ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);
Console.Write("Введите номер переменной Y первой точки => ");
string inputB = Console.ReadLine();
int B = int.Parse(inputB);
Console.Write("Введите номер переменной X второй точки => ");
string inputC = Console.ReadLine();
int C = int.Parse(inputC);
Console.Write("Введите номер переменной Y второй точки => ");
string inputD = Console.ReadLine();
int D = int.Parse(inputD);
double answer = Math.Sqrt((A - C) * (A - C) + (B - D) * (B - D));
Console.WriteLine(answer);







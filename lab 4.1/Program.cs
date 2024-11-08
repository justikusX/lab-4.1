double [] array = { 1.5, 2.5, 3.4, 5.3, 7.2 };
Console.WriteLine("введите число R");
double R = int.Parse(Console.ReadLine());
double C_V = array[0];
int C_I = 0;
double min_Diff = Math.Abs(array[0] - R);
for (int i = 1; i < array.Length; i++)
{
    double C_D =Math.Abs(array[i]-R);
    if (C_D < min_Diff)
    {
        min_Diff = C_D;
        C_V = array[i];
        C_I = i;
    }
    Console.WriteLine();

}
Console.WriteLine($"Ближайшее число:{C_V} \n Индекс: {C_I}");
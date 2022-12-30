Console.WriteLine("enter number to start the domain");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter number to end the domain");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(" The perfect numbers from {0} to {1} is : ", num1, num2);
for (int i = num1; i <= num2; i++)
{
    int sum = 0;
    for (int j = 1; i > j; j++)
    {
        if (i % j == 0)
            sum += j;
    }
    if (sum == i && sum != 0)
        Console.WriteLine(i);
}
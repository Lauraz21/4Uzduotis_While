
//4

Console.WriteLine("Iveskite sveikaji skaiciu");
int userInput = Convert.ToInt32(Console.ReadLine());

int i = 1;
int j = 1;

while (i <= userInput)
{
    j = 1;

    while (j <= i)
    {
        Console.Write(i);
        j++;
    }

    i++;
    Console.WriteLine();
}





//4.1


Console.WriteLine("Iveskite pinigu suma: ");
int sum = Convert.ToInt32(Console.ReadLine());

int[] money = {10, 20, 50 , 100 , 200, 500};
int i = 0;
int cashOut = 0;

while (i < money.Length)
{
    if (money[i] <= sum - cashOut)
    {
        cashOut += money[i];
        Console.WriteLine(money[i] + "  EUR");

    if (money[i] <= cashOut)
        {
            i += 0;
        }

    else
        {
            i++;
        }
            i++;
    }
}

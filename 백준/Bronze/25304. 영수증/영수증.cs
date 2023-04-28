int totalPrice = int.Parse(Console.ReadLine());
int totalCount  = int.Parse(Console.ReadLine());

int checkPrice = 0;
int price = 0;
int count = 0;
for(int i = 0; i< totalCount; i++)
{
    string[] priceAndCount = Console.ReadLine().Split(' ');

    price = int.Parse(priceAndCount[0]);
    count = int.Parse(priceAndCount[1]);

    checkPrice += price * count;
}

if (totalPrice == checkPrice)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
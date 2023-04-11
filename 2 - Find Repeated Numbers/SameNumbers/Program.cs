int num,i,j=0,temp;
Console.Write("Please enter how many elements do you want to add your array : ");
num = int.Parse(Console.ReadLine());
int []arr = new int[num];
for (i = 0; i < num; i++)
{
    Console.Write((i + 1) + ".Element : ");
    arr[i] = int.Parse(Console.ReadLine());

}
Console.WriteLine("The Array:");
for (i = 0; i < num; i++)
{
    Console.Write(arr[i]+"\t");

}
Console.WriteLine("\nThe Repeated Elements:");
while (num > j)
{
    temp = arr[j];
    for (i = 0; i < num; i++)
    {
        if (j == i)
        {
            break;
        }
        if (temp == arr[i])
        {
            Console.Write(temp + "\t");
        }

    }
    j++;
}




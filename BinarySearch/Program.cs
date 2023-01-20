using System.Security.Cryptography.X509Certificates;

int[] array = new int[10];


for (int i = 0;i < array.Length; i++)
{
    Console.WriteLine("Enter element", i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Enter x that we are looking for");
int x = Convert.ToInt32(Console.ReadLine());

int l = 0;
int r = array.Length+1;
int m = 0;
while(l + 1 < r)
{
    m = (l + r) / 2;
    if (array[m] > x)
    {
        r = m;
    }
    if (array[m] < x)
    {
        l = m;
    }
    if (array[m] == x)
    {
        Console.Write(m+1);
        break;
    }
}



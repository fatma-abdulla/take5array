using Microsoft.VisualBasic;
using System.Numerics;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Number ;" + i);

}

//bonus:)
 int Value = 0;
while (Value <= 5)
{
    Console.WriteLine("print" +Value);
    Value += 1;
}

 //taske2  1: Create an array to store your weekly class schedule. Print the days of the week.

string[] xx = new string[6];

xx[0] = "sunday";
xx[1] = "monday";
xx[2] = "tusday";
xx[3] = "wensday";
xx[4] = "thersday";
xx[5] = "satarday";


for (int i=0;i<xx.Length;i++)
{
    Console.WriteLine("print "+xx[i]);


}
//task3 

int[] number = { 1, 2, 3, 4, 5 };
int total = 0;
foreach(int num in  number)
{
    total += num;
}
Console.WriteLine("the sum of the array is ; " + total);



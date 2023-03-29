String s_a = Console.ReadLine()!;
int a = int.Parse(s_a);
for (int i=1; i<a;i++)
{
int c=i%2;
if (c==0)Console.WriteLine(i);
}
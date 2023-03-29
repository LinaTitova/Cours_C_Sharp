String s_a = Console.ReadLine()!;
String s_b = Console.ReadLine()!;
String s_c = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);
if (a<b&&b>c) Console.WriteLine("Max:"+b);
else if (a<c&&b<c) Console.WriteLine("Max:"+c);
else Console.WriteLine("Max:"+a);
// See https://aka.ms/new-console-template for more information
for (int i=0; i <= 2; ++i)
{
    Console.WriteLine("Outer: " + i);
}

for(int j=0; j <= 3; j++)
{
    Console.WriteLine("inner: " + j);
}
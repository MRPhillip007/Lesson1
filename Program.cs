// Main functionality 
Console.WriteLine("Hello, nice to meet you :) ");


// Another developer's work 
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("{0}, welcome back! ", name);
}
else
{
    Console.WriteLine("Please, enter valid name... ");
}

Console.ReadLine();

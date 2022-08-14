
using ConceptsPoo;

Console.WriteLine("Hello, World!");

try
{
	Console.WriteLine(new Date(2022, 2, 11));
	Console.WriteLine(new Date(1985, 4, 23));
	Console.WriteLine(new Date(1987, 5, 12));
}
catch (Exception error )
{

	Console.WriteLine(error.Message);
}
Console.Read();
// See https://aka.ms/new-console-template for more information
using Exercise_3;

//var Lasse = new Person();
//Lasse.Age = 30;

PersonHandler pHandler = new PersonHandler();
try
{
    pHandler.CreatePerson(23, "Lisa", "S", 163, 75);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}



// See https://aka.ms/new-console-template for more information
using Exercise_3;

//var Lasse = new Person();
//Lasse.Age = 30;

PersonHandler pHandler = new PersonHandler();
//To catch the exception that might be cast in the Person class.
try
{
    //Just trying out the code by creating a fake person. Testing the other methods in the PersonHandler.
 var lisa = pHandler.CreatePerson(23, "Lisa", "Svensson", 163, 75);
    Console.WriteLine(pHandler.GetFullName(lisa));
    Console.WriteLine(pHandler.GetAge(lisa));
    
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
  var adam = pHandler.CreatePerson(30, "Adam", "Avensson", 180, 83);
    Console.WriteLine($"Name: {adam.FName} {adam.LName}, age: {adam.Age}years");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

try
    //Testing the Try/Catch part.
{
    var lotta = pHandler.CreatePerson(38, "Lisa", "P", 171, 74);
    Console.WriteLine($"Name: {lotta.FName} {lotta.LName}, age: {lotta.Age}years");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Bird test = new Bird("Kalle", 0.5, 2);
test.WingSpan = 0.8;
Console.WriteLine(test.Stats());


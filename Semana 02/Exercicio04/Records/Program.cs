﻿Person person1 = new("Teddy", "Smith");
Person person2 = new("Teddy", "Smith");

Console.WriteLine(person1 == person2);

Person person3 = person2 with { LastName = "Brewski" };
Console.WriteLine(person3.ToString());


public record Person(string FirstName, string LastName);
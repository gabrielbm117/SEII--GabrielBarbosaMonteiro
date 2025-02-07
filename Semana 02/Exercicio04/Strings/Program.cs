using System.Text;

var petFish = "puffer fish";


petFish = "porcupine " + petFish;


Console.WriteLine($"In my salt water aquarium, I will have a {petFish}");

Console.WriteLine(petFish);

Console.WriteLine(petFish.Replace("porcupine", "blue dot"));


StringBuilder newCrustacean = new StringBuilder();
newCrustacean.Append("red lobster");
Console.WriteLine(newCrustacean);
newCrustacean.Replace("red", "blue");
Console.WriteLine(newCrustacean);

string[] favoriteRats = ["fancy rat", "brown rat", "radioactive rat", "wolf rat"];

var newFavoriteRats = favoriteRats.Where((e) => e.StartsWith("b"));

foreach(var rat in newFavoriteRats) 
{
    Console.WriteLine(rat);
}

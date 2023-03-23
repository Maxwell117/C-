List<string> games=new List<string>();
games.Add("Doom 2");
games.Add("Ocarina Of Time");
games.Add("Pokemon Red");
games.Add("Heretic");
games.Add("phantasy star");
games.Add("Quake");
games.Add("Blood");
games.Add("Super Mario 64");
games.Add("Skyrim");

var OrderedGames=games.OrderBy(name=>name.Length);

foreach(var game in games)
{
Console.WriteLine(game);
}

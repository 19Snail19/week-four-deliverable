Random random = new Random();
 
string[] pokemon = ["Bulbasaur", "Squirtle", "Charmander", "EMPTY", "EMPTY", "EMPTY"];
string[] encounters = ["Natu", "Sandshrew", "Ledyba", "Sentret", "Geodude", "Magikarp"];

int index = random.Next(encounters.Length);

Console.WriteLine("\nStarting Team\n-------------");

for (int i = 0; i < pokemon.Length; i++)
{
    Console.WriteLine(pokemon[i]);
}

Console.WriteLine("\nWild Pokemon!\n-------------");

for (int i = 0; i < encounters.Length; i++)
{
    Console.WriteLine(encounters[i]);
}

if (pokemon[3] == "EMPTY")
{
    pokemon[3] = encounters[index];
}

if (pokemon[4] == "EMPTY")
{
    index = random.Next(encounters.Length);
    pokemon[4] = encounters[index];
}

if (pokemon[5] == "EMPTY")
{
    index = random.Next(encounters.Length);
    pokemon[5] = encounters[index];
}

Console.WriteLine("\nNew Party!\n----------");

for (int i = 0; i < pokemon.Length; i++)
{
    Console.WriteLine(pokemon[i]);
}
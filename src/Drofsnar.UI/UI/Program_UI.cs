using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



public class Program_UI
{
    private Player player = new Player();
    private string filePath = @"C:\Users\Terry\Documents\Teacher_Key\dotnetProjects\Drofsnar_The_Bird_Man\src\Drofsnar.UI\StarterFile.txt";
    private List<string> lines = new List<string>();
    string[] entries;


    private string[] GetEnemyDataFromFile()
    {
        lines = File.ReadAllLines(filePath).ToList();
        foreach (var word in lines)
        {
            entries = word.Split(',');
        }
        return entries;
    }

    private void LoadEnemies(string[] entries)
    {
        Console.Clear();
        foreach (var entry in entries)
        {

            Console.WriteLine(entry);
            if (entry == "Bird")
            {
                Bird bird = new Bird();
                player.EatBird(bird);
            }
            else if (entry == "CrestedIbis")
            {
                Crested_Ibis cI = new Crested_Ibis();
                player.EatBird(cI);
            }
            else if (entry == "GreatKiskudee")
            {
                Great_Kiskudee gK = new Great_Kiskudee();
                player.EatBird(gK);
            }
            else if (entry == "RedCrossbill")
            {
                Red_Crossbill rC = new Red_Crossbill();
                player.EatBird(rC);
            }
            else if (entry == "Red-neckedPhalarope")
            {
                Red_Necked_Phalarope rN = new Red_Necked_Phalarope();
                player.EatBird(rN);
            }
            else if (entry == "EveningGrosbeak")
            {
                Evening_Grosbeak eG = new Evening_Grosbeak();
                player.EatBird(eG);
            }
            else if (entry == "GreaterPrairieChicken")
            {
                Greater_Prairie_Chicken gP = new Greater_Prairie_Chicken();
                player.EatBird(gP);
            }
            else if (entry == "IcelandGull")
            {
                Iceland_Gull iG = new Iceland_Gull();
                player.EatBird(iG);
            }
            else if (entry == "Orange-belliedParrot")
            {
                Orange_Bellied_Parrot oBP = new Orange_Bellied_Parrot();
                player.EatBird(oBP);
            }
            else if (entry == "VulnerableBirdHunter")
            {
                VulnerableBirdHunter vbh = new VulnerableBirdHunter();
                player.EatBird(vbh);
            }
            else if (entry == "FireBird")
            {
                FireBird fb = new FireBird();
                player.EatBird(fb);
            }
            else if (entry == "InvincibleBirdHunter")
            {
                player.LooseLife();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine($"Lives: {player.Lives}");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        Console.WriteLine($"DrofsnarPoints: {player.Points}!");
        Console.WriteLine($"DrofsnarLives: {player.Lives}!");
    }

    public void Run()
    {
        LoadEnemies(GetEnemyDataFromFile());
    }

}

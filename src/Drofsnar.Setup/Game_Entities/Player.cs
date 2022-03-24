using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Player
{
    private int _points = 5000;
    private int _lives = 3;
    public int Points
    {
        get { return _points; }
        set
        {
            _points = value;
            if (value >= 10_000 && !HasEarnedExtraLife)
            {
                HasEarnedExtraLife = true;
                if (HasEarnedExtraLife)
                {
                    FreeLife();
                }

            }

            _points = value;
        }
    }
    public int Lives
    {
        get { return _lives; }

    }

    private void FreeLife()
    {
        _lives += 1;
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.WriteLine("Extra Life Earned!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public bool HasStopper { get; set; }
    public bool HasEarnedExtraLife { get; set; } = false;

    public void EatBird(IRareBird bird)
    {
        Points += bird.PointValue;
        System.Console.WriteLine($"Total Points are: {_points}. \n" +
        $"InitalPts: {bird.PointValue}.\n" +
        "---------------------------------------------");
    }
    public void LooseLife()
    {
        _lives--;

        if (_lives == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Your on your last leg!!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        if (_lives < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Drofsnar, You are Dead!");
            Console.ForegroundColor = ConsoleColor.White;
        }


        // if (Lives > 0)
        // {
        //     _lives--;
        // }
        // else
        // {
        //     Console.ForegroundColor = ConsoleColor.Red;
        //     System.Console.WriteLine("Drofsnar, You are Dead!");
        //     Console.ForegroundColor = ConsoleColor.White;
        // }
    }
}

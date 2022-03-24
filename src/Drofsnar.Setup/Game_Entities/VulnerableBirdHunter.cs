using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class VulnerableBirdHunter : RareBird
{
    private static int _count;
    private int _maxValue = 1600;
    public VulnerableBirdHunter()
    {
        Name = "Vulnerable Bird Hunter";
        _count++;
        if (_count == 1)
        {
            PointValue = 200;
        }
        else if (PointValue < _maxValue)
        {
            PointValue = _count * 200;
        }
        else
        {
            PointValue = _maxValue;
        }
    }
}

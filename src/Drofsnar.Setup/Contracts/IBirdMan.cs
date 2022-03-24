using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public interface IBirdMan
{
    int Points { get; set; }
    int Lives { get; set; }
    bool HasStoper { get; set; }
    void FreeLife();
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Random : IRandom
    {
	    public uint Next(int lower, int higher)
	    {
		    var n = (uint) new Random().Next(lower, higher);
		    return n;
	    }
    }
}

using System;
using System.Collections.Generic;

namespace Roulette
{
    public class Roulette
    {
	    private readonly List<Field> _fields;
	    private Field _result;

		public Roulette(IFieldFactory FF)
	    {

	    }

	    public void Spin()
	    {
		    var n = (uint)IRandom.Next(0, _fields.Count());
		    _result = _fields[(int) n];
	    }
    }
}

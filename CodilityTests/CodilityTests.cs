using System;
using System.IO;
using System.Collections.Generic;

namespace Codility
{  
  public class CodilityTests
  {
    public CodilityTests()
    {
      MapReduceFilter();
    }

    public int MissingElement(int[] A)
    {
      for(in)
    }

    public void MapReduceFilter()
    {
      /* Map */ OutputEnumerable("Map", Enumerable.Range(1,10).Select(x => x + 2));
      /* Reduce */ OutputEnumerable("Reduce"), Enumerable.Range(1,10).Aggregate(0, (acc, x) => acc + x));
      /* Filter */ OutputEnumerable("Filter"), Enumberable.Range(1,10).Where(x => x % 2 == 0));

      /* Internal Sample */
    }

    private void OutputEnumerable(string identifier, IEnumerable enumerable)
    {
      Console.WriteLine("-- {0} --", identifier);
      foreach(var item in enumerable)
      {
        Console.WriteLine(item);
      }
    }
  }
}
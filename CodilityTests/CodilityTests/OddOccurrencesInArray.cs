using System;

namespace CodilityTests
{
	public class OddOccurrencesInArray
	{
		public int Solution(int[] A)
		{
			var temp = 0;
			for (int i = 0; i < A.Length; i++)
			{
				temp = temp ^ A[i];
			}
			return temp;
		}
	}
}

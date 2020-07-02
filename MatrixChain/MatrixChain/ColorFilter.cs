using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixChain
{
	public class ColorFilter : Handler
	{

		int sum = 0;

		public override void HandleRequest(int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j]++;

				}
			}

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					sum += matrix[i, j];

				}

			}
			if (sum == 0)
			{
				setNext(null);
			}
			if (next != null)
			{
				setNext(next);
			}
		}
	}
}

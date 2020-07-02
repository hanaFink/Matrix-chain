using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixChain
{
    class ConeFilter:Handler
    {
		int sum = 0;

		public override void HandleRequest(int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				if (i == 0 || i == 1 || i == 98 || i == 99)
				{
					for (int j = 0; j < matrix.GetLength(1); j++)
					{
						matrix[i, j] = 0;

					}
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

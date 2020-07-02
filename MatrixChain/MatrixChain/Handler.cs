using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixChain
{
	public abstract class Handler
    {
		

			protected Handler next;

			public void setNext(Handler next)
			{
				this.next = next;
			}

			public abstract void HandleRequest(int[,] matrix);

		
	}
}

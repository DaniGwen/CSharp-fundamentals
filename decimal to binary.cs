using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimal_to_binary
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputdecimal = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();
			if (inputdecimal == 0)
			{
				Console.WriteLine(0);
			}

			while (inputdecimal > 0)
			{
				stack.Push(inputdecimal % 2);
				inputdecimal /= 2; 
			}
			while (stack.Count > 0)
			{
				Console.Write(stack.Pop());
			}
			Console.WriteLine();
		}
	}
}

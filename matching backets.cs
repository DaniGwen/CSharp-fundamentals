using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matcheing_Brackets
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			Stack<int> stackOpenBracketIndexes = new Stack<int>();
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == '(')
				{
					stackOpenBracketIndexes.Push(i);
				}
				if (input[i] == ')')
				{
					var openBracketIndex = stackOpenBracketIndexes.Pop();
					var length = i - openBracketIndex + 1;
					Console.WriteLine(input.Substring(openBracketIndex, length));
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var text = input.Split(' ');
			Stack<char> stack = new Stack<char>();
			for (int i = 0; i < text.Length; i++)
			{
				char[] toChar = text[i].ToCharArray();
				stack.Push(' ');
				for (int j = 0; j < toChar.Length; j++)
				{
					stack.Push(toChar[j]);
				}
			}
			while (stack.Count != 0)
			{
				Console.Write(stack.Pop());
			}
			Console.WriteLine();
		}
	}
}

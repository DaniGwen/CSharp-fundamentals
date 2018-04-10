using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Simple_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var nums = input.Split(' ');
			Stack<string> stack = new Stack<string>(nums.Reverse());

			while (stack.Count > 1)
			{
				var leftOperant = int.Parse(stack.Pop());
				var operation = stack.Pop();
				var rightOperant = int.Parse(stack.Pop());

				switch (operation)
				{
					case "-": stack.Push((leftOperant - rightOperant).ToString());
						break;
					case "+": stack.Push((leftOperant + rightOperant).ToString());
						break;
				}
			}
			Console.WriteLine(stack.Pop());
		}
	}
}

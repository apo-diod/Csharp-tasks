using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
	class Program
	{
    private static void printMaximLength(string[] elems){
      if (elems.Length == 1) {
        Console.WriteLine(elems[0]);
        return;
      }
      int maxIndex = 0;
      int index = 0;
      foreach(string element in elems){
        if (element.Length > elems[maxIndex].Length){
          maxIndex = index;
        }
        index++;
      }
      Console.WriteLine(elems[maxIndex]);
      List<string> temp = elems.ToList();
      temp.RemoveAt(maxIndex);
      printMaximLength(temp.ToArray());
    }
		public static void Main(string[] args)
		{
      string inp = Console.ReadLine();
      printMaximLength(inp.Split(' '));
			Console.ReadKey(true);
		}
	}
}

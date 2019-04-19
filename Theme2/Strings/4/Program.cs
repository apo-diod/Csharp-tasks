using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
	class Program
	{
    private static string uniqueSortedString(string inp){
      string[] temp = inp.Split(' ');
      List<string> input = temp.ToList();
      HashSet<string> temporar = new HashSet<string>();
      foreach(string elem in temp){
        temporar.Add(elem);
      }
      input = temporar.ToList();
      input = input.OrderBy(q => q).ToList();
      string result = "";
      foreach(string elem in input){
        result += elem+" ";
      }
      return result;
    }
		public static void Main(string[] args)
		{
      string inp = Console.ReadLine();
      Console.WriteLine(uniqueSortedString(inp));
			Console.ReadKey(true);
		}
	}
}

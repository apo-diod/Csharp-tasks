using System;

namespace Task1
{
	class Program
	{
    private static int getCountOfPairs(string str){
      char remembered = str[0];
      int count = 0;
      foreach(char letter in str)
      {
        if (letter == remembered)
        {
          count++;
        }
        remembered = letter;
      }
      return count-1;
    }

		public static void Main(string[] args)
		{
      string inp = Console.ReadLine();
      Console.WriteLine(getCountOfPairs(inp));
			Console.ReadKey(true);
		}
	}
}

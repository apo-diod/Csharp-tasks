using System;

namespace Task1
{
	class Program
	{
    private static string createTelephoneNumber(string numb){
      string result = "";
      for(int i = numb.Length-1; i >= 0; i--){
        if (i%2 == 1 && i != numb.Length-1){
          result+="-";
        }
        result+=numb[numb.Length-1-i];
      }
      return result;
    }
		public static void Main(string[] args)
		{
      string inp = Console.ReadLine();
      Console.WriteLine(createTelephoneNumber(inp));
			Console.ReadKey(true);
		}
	}
}

using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Введите путь к файлу со значениями x вида C:\\...");
    string path = Console.ReadLine();
    Console.WriteLine("Введите путь к выходному файлу");
    FileStream fileWriter = new FileStream(Console.ReadLine(), FileMode.OpenOrCreate);
    StreamReader file = new StreamReader(path);
    string text = "";
    string line;
    double result = 0;
    while ((line = file.ReadLine()) != null) {
      double x = double.Parse(line);
      if (x >= -3 && x <= 3) {
        result = 2/(x*x+1);
      } else {
        result = Math.Abs(x*x*x - 7)/x;
      }
      text += result.ToString() + "\n";
    }
    file.Close();
    byte[] array = System.Text.Encoding.Default.GetBytes(text);
    fileWriter.Write(array, 0, array.Length);
  }
}

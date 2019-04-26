using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Введите путь к файлу вида C:\\...");
    string path = Console.ReadLine();
    FileStream file = new FileStream(path, FileMode.OpenOrCreate);
    string text = "";
    for (double i = -6; i <= 6; i+=1.5){
      if (i != 6) {
        text += i.ToString()+"\n";
      } else {
        text += i.ToString();
      }
    }
    byte[] array = System.Text.Encoding.Default.GetBytes(text);
    file.Write(array, 0, array.Length);
  }
}

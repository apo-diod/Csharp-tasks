using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Введите путь к выходному файлу");
    FileStream fileWriter = new FileStream(Console.ReadLine(), FileMode.OpenOrCreate);
    string text = "";
    int count = 0;
    for (int i = 1; i <= 9; i++) {
      for (int j = 0; j <= 9; j++) {
        for (int k = 0; k <= 9; k++) {
          if (count%5 == 0 && count != 0) {
            text += "\n";
          }
          text += i.ToString()+j.ToString()+k.ToString()+j.ToString()+i.ToString()+" ";
          count += 1;
          if (count == 50) {
            break;
          }
        }
        if (count == 50) {
          break;
        }
      }
      if (count == 50) {
        break;
      }
    }
    byte[] array = System.Text.Encoding.Default.GetBytes(text);
    fileWriter.Write(array, 0, array.Length);
  }
}

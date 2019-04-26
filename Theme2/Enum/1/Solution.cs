using System;

class MainClass {
  enum Firms {
    Facebook = 10000,
    Google = 12000,
    Apple = 9500
  }
  class Worker {
    public int salary;
    public void GoToFirm(string firm) {
      if (firm == "Facebook") {
        salary = (int)Firms.Facebook;
      } else if (firm == "Google") {
        salary = (int)Firms.Google;
      } else if (firm == "Apple") {
        salary = (int)Firms.Apple;
      } else {
        salary = 0;
      }
    }
  }
  public static void Main (string[] args) {
    string firm = Console.ReadLine();
    Worker man = new Worker();
    man.GoToFirm(firm);
    if man.salary == 0 {
      Console.WriteLine("Фирма некорректна");
    } else {
      Console.WriteLine(man.salary);
    }
  }
}

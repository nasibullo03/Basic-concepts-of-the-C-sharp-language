/***********************************************
 * Автор:    Халилов Н.Х.                       *
 * Дата:     14.02.2022                         *
 * Название: 1. Базовые понятия языка С#        *
 ***********************************************/
using System;

namespace Basic_concepts_C_Sharp {
  class Program {
    static void Main(string[] args) {

      String Number, NewNumber="";
            
      Console.Write("Введите число:");

      Number = Console.ReadLine();

      for (int Step = 0; Step < Number.Length; Step++) {
        if (Step == 1) {
          continue;
        }
                NewNumber += Number[Step];
      }

      NewNumber += Number[1];

      Console.WriteLine(Number);

    }
  }
}
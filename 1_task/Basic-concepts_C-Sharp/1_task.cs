/***********************************************
 * Автор:    Халилов Н.Х.                       *
 * Дата:     14.02.2022                         *
 * Название: 1. Базовые понятия языка С#        *
 ***********************************************/
using System;

namespace Basic_concepts_C_Sharp {
  class Program {
    static void Main(string[] args) {

      int Degree, Number, Result;

      Console.Write("Введите число a:");
      Number = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите число n:");
      Degree = Convert.ToInt32(Console.ReadLine());
     
      Result = 1;

      for (int Step = 0; Step < Degree; Step++) {
        Result *= Number;
      }

      Console.WriteLine(Result);

    }
  }
}
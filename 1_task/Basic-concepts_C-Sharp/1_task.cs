/***********************************************
 * Автор:    Халилов Н.Х.                       *
 * Дата:     14.02.2022                         *
 * Название: 1. Базовые понятия языка С#        *
 ***********************************************/
using System;

namespace Basic_concepts_C_Sharp {
  class Program {
    static void Main(string[] args) {

      int degree, number, result;

      Console.Write("Введите число a:");
      number = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите число n:");
      degree = Convert.ToInt32(Console.ReadLine());
     
      result = 1;

      for (int step = 0; step < degree; step++) {
        result *= number;
      }

      Console.WriteLine(result);

    }
  }
}
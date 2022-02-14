/***********************************************
 * Автор:    Халилов Н.Х.                       *
 * Дата:     14.02.2022                         *
 * Название: 1. Базовые понятия языка С#        *
 ***********************************************/
using System;

namespace Basic_concepts_C_Sharp {
  class Program {
    static void Main(string[] args) {

      String number, newNumber="";
            

      Console.Write("Введите число:");

      number = Console.ReadLine();

            foreach (int el in number)
            {
                if (el == 1)
                {
                    continue;
                }

                newNumber += number[el];
            }
            
           /* for (int step = 0; step < number.Length; step++) {
       
      }*/

      newNumber += number[1];

      Console.WriteLine(number);

    }
  }
}
/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class ControlWork {
  
  public static string IIF(bool condition, string ValueTrue, string ValueFasle)
  {
    if (condition) 
       return ValueTrue;
    else
       return ValueFasle;
      
  }
  
  
  static void Main() {
    Console.WriteLine("Введите элементы массива через пробел");
    string input = Console.ReadLine();
    string[] inputArray = input.Split(' ');
    Console.WriteLine($"Количество элементов {inputArray.GetLength(0)}");
    
    string s = "";
    
    for (int i = 0; i < inputArray.GetLength(0); i++){
        if (inputArray[i].Length<=3) 
            s = s + IIF(s=="",""," ")+inputArray[i];     
        
    }
    
    string[] outputArray = s.Split(' ');
    s = "";
    
   for (int i = 0; i < outputArray.GetLength(0); i++){
            s = s + IIF(s=="",""," ")+outputArray[i];     
        
    }
    
    Console.WriteLine($"Результат {s}");
    
  }
}

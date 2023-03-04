using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        // Создаем пустой список для хранения строк, длина которых меньше или равна 3 символам
        List<string> shortStrings = new List<string>();

        // Запрашиваем у пользователя количество строк, которые необходимо ввести
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());

        // Считываем строки и добавляем их в список, если их длина меньше или равна 3 символам
        for (int i = 0; i < n; i++) {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            if (s.Length <= 3) {
                shortStrings.Add(s);
            }
        }

        // Выводим полученный список на экран
        Console.WriteLine("Строки, длина которых меньше или равна 3 символам:");
        foreach (string s in shortStrings) {
            Console.WriteLine(s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionare
{
    class Program
    {
        const string answer0_1 = "Да";
        const string answer0_2 = "Нет";
        const string answer1_1 = "700$";
        const string answer1_2 = "500$";
        const string answer1_3 = "1000$";
        const string answer1_4 = "650$";
        const string answer2_1 = "UMP-45";
        const string answer2_2 = "AWP";
        const string answer2_3 = "M249";
        const string answer2_4 = "SCAR-20";
        const string answer3_1 = "M4A1-S";
        const string answer3_2 = "Desert Eagle";
        const string answer3_3 = "AK-47";
        const string answer3_4 = "USP-S";
        const string answer4_1 = "G3SG1";
        const string answer4_2 = "AK-47";
        const string answer4_3 = "SCAR-20";
        const string answer4_4 = "AWP";
        const string answer5_1 = "20/120";
        const string answer5_2 = "30/120";
        const string answer5_3 = "50/10";
        const string answer5_4 = "10/50";
        const string answer6_1 = "Россия";
        const string answer6_2 = "Украина";
        const string answer6_3 = "Германия";
        const string answer6_4 = "Израиль";
        const string answer7_1 = "18";
        const string answer7_2 = "13";
        const string answer7_3 = "2";
        const string answer7_4 = "16";
        const string answer8_4 = "Лес";
        const string answer8_2 = "Мерефа";
        const string answer8_3 = "Харьковская";
        const string answer8_1 = "Бор";
        const string answer9_1 = "Cobblestone и Overpass";
        const string answer9_2 = "Cobblestone и Agency";
        const string answer9_3 = "Dust и Offis";
        const string answer9_4 = "Cobblestone и Inferno";
        const string answer10_1 = "Майор (30 ранг)";
        const string answer10_2 = "Капрал (8 ранг)";
        const string answer10_3 = "Маршал (40 ранг)";
        const string answer10_4 = "Генерал-Маршал (50 ранг)";
        const string answer11_1 = "2014";
        const string answer11_2 = "2019";
        const string answer11_3 = "2010";
        const string answer11_4 = "2015";
        const string answer12_1 = "14";
        const string answer12_2 = "11";
        const string answer12_3 = "1";
        const string answer12_4 = "20";
        const string answer13_1 = "Steam";
        const string answer13_2 = "Valve";
        const string answer13_3 = "Microsoft";
        const string answer13_4 = "Ubisoft";
        const string answer14_1 = "Нож";
        const string answer14_2 = "AWP";
        const string answer14_3 = "Scar-20";
        const string answer14_4 = "Zeus x27";
        const string question0 = "Знаеш ли ты игру CS-GO";
        const string question1 = "Сколько стоит Desert Eagle в CS-GO";
        const string question2 = "Какое самое дорогое оружие в CS-GO";
        const string question3 = "Какое самое точное оружие в CS-GO (Кроме Снайперских винтовок)";
        const string question4 = "Какое самое мощное оружие по урону в CS-GO";
        const string question5 = "Какая обойма у Dual Berettas";
        const string question6 = "Страна создания АК-47";
        const string question7 = "Сколько званий в CS-GO (В Соревновательном режиме)";
        const string question8 = "Кокая позиция (из перечисленых) есть в CS-GO";
        const string question9 = "На каких картах есть отсылка на скин AWP Dragon Lore";
        const string question10 = "При каком ранге даёт медаль за службу";
        const string question11 = "С какова года начали выдавать медали за службу";
        const string question12 = "Сколько ножей в CS-GO";
        const string question13 = "Какая компания создала CS-GO";
        const string question14 = "За какое оружее в CS-GO не дают денег";
        const string dot = ".";
        const int one = 1;
        const int one2 = 2;
        const int one3 = 3;
        const int one4 = 4;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Проверим на сколько % ты знаешь CS-GO");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(question0);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer0_1);
            Console.WriteLine(one2 + dot + answer0_2);
            int answer = Int32.Parse(Console.ReadLine());
            bool isTrue = answer != 1;
            if (isTrue)
            {
                Console.WriteLine("Ну ты и Даня. Ты знаешь CS-GO");
                return;
            }
            Console.WriteLine(question1);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer1_1);
            Console.WriteLine(one2 + dot + answer1_2);
            Console.WriteLine(one3 + dot + answer1_3);
            Console.WriteLine(one4 + dot + answer1_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 1;
            if (isTrue)
            {
                Console.WriteLine("Ты хоть знаеш что на В закупатца можно мм?");
                return;
            }
            Console.WriteLine(question2);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer2_1);
            Console.WriteLine(one2 + dot + answer2_2);
            Console.WriteLine(one3 + dot + answer2_3);
            Console.WriteLine(one4 + dot + answer2_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 3;
            if (isTrue)
            {
                Console.WriteLine("Ты хоть на цены смотриш при покупке, или фигаришь на угат?");
                return;
            }
            Console.WriteLine(question3);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer3_1);
            Console.WriteLine(one2 + dot + answer3_2);
            Console.WriteLine(one3 + dot + answer3_3);
            Console.WriteLine(one4 + dot + answer3_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 2;
            if (isTrue)
            {
                Console.WriteLine("Про 700$ ты знаеш а про точность не надо, надо зажимать.");
                return;
            }
            Console.WriteLine(question4);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer4_1);
            Console.WriteLine(one2 + dot + answer4_2);
            Console.WriteLine(one3 + dot + answer4_3);
            Console.WriteLine(one4 + dot + answer4_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 4;
            if (isTrue)
            {
                Console.WriteLine("Ты неудачник");
                return;
            }
            Console.WriteLine(question5);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer5_1);
            Console.WriteLine(one2 + dot + answer5_2);
            Console.WriteLine(one3 + dot + answer5_3);
            Console.WriteLine(one4 + dot + answer5_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 2;
            if (isTrue)
            {
                Console.WriteLine("Ты знаеш что такое Dual Berettas?");
                return;
            }
            Console.WriteLine(question6);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer6_1);
            Console.WriteLine(one2 + dot + answer6_2);
            Console.WriteLine(one3 + dot + answer6_3);
            Console.WriteLine(one4 + dot + answer6_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 1;
            if (isTrue)
            {
                Console.WriteLine("Ты неудачник");
                return;
            }
            Console.WriteLine(question7);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer7_1);
            Console.WriteLine(one2 + dot + answer7_2);
            Console.WriteLine(one3 + dot + answer7_3);
            Console.WriteLine(one4 + dot + answer7_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 1;
            if (isTrue)
            {
                Console.WriteLine("Ты неудачник");
                return;
            }
            Console.WriteLine(question8);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer8_1);
            Console.WriteLine(one2 + dot + answer8_2);
            Console.WriteLine(one3 + dot + answer8_3);
            Console.WriteLine(one4 + dot + answer8_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 4;
            if (isTrue)
            {
                Console.WriteLine("Ты неудачник");
                return;
            }
            Console.WriteLine(question9);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer9_1);
            Console.WriteLine(one2 + dot + answer9_2);
            Console.WriteLine(one3 + dot + answer9_3);
            Console.WriteLine(one4 + dot + answer9_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 1;
            if (isTrue)
            {
                Console.WriteLine("Ты неудачник");
                return;
            }
            Console.WriteLine(question10);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer10_1);
            Console.WriteLine(one2 + dot + answer10_2);
            Console.WriteLine(one3 + dot + answer10_3);
            Console.WriteLine(one4 + dot + answer10_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 3;
            if (isTrue)
            {
                Console.WriteLine("Ты неудачник");
                return;
            }
            Console.WriteLine(question11);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer11_1);
            Console.WriteLine(one2 + dot + answer11_2);
            Console.WriteLine(one3 + dot + answer11_3);
            Console.WriteLine(one4 + dot + answer11_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 4;
            if (isTrue)
            {
                Console.WriteLine("Ты неудачник");
                return;
            }
            Console.WriteLine(question12);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer12_1);
            Console.WriteLine(one2 + dot + answer12_2);
            Console.WriteLine(one3 + dot + answer12_3);
            Console.WriteLine(one4 + dot + answer12_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 1;
            if (isTrue)
            {
                Console.WriteLine("Ты неудачник");
                return;
            }
            Console.WriteLine(question13);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer13_1);
            Console.WriteLine(one2 + dot + answer13_2);
            Console.WriteLine(one3 + dot + answer13_3);
            Console.WriteLine(one4 + dot + answer13_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 2;
            if (isTrue)
            {
                Console.WriteLine("Ты неудачник");
                return;
            }
            Console.WriteLine(question14);
            Console.WriteLine();
            Console.WriteLine(one + dot + answer14_1);
            Console.WriteLine(one2 + dot + answer14_2);
            Console.WriteLine(one3 + dot + answer14_3);
            Console.WriteLine(one4 + dot + answer14_4);
            answer = Int32.Parse(Console.ReadLine());
            isTrue = answer != 4;
            if (isTrue)
            {
                Console.WriteLine("Ты неудачник");
                return;
            }
            Console.WriteLine("You win");

        }
    }
}


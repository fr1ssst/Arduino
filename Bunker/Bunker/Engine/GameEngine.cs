using Bunker.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.GameEngine
{
    class Engine
    {
        Random random = null;
        Player player = null;

        public void Text(string text1, string text2, ConsoleColor color1 = ConsoleColor.White, ConsoleColor color2 = ConsoleColor.Gray) 
        {
            Console.ForegroundColor = color1;
            Console.Write(text1);

            Console.ForegroundColor = color2;
            Console.Write(text2);

            Console.WriteLine();
        }
        public void Value(string text1, int value, ConsoleColor color1 = ConsoleColor.White, ConsoleColor color2 = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color1;
            Console.Write(text1);

            Console.ForegroundColor = color2;
            Console.Write(value);

            Console.WriteLine();
        }
        public void History() 
        {
            string[] historys = {"1", "2"};
            Text(historys[random.Next(0, historys.Length)], null, color1 : ConsoleColor.DarkGreen);
        }
        public Player CreatePlayer()
        {
            random = new Random();

            string[] namesM = {"Вася", "Петро", "Віктор", "Єгор", "Гліб",
                "Іван", "Ілля", "Артур", "Вадим", "Тимофій","Михайло","Павло",
                "Євген","Сергій","Арсен","Юрій","Тимур","Давид","Марк","Андрій",
                "Артем","Данило","Денис","Максим","Олег","Олександр","Орест","Роман",
                "Назар","Микита","Руслан","Степан"};
            string[] namesW = {"Ольга", "Катя", "Аліса", "Дарина", "Евеліна", "Єва",
                "Інна", "Ірина", "Катерина", "Марина", "Марія", "Надія", "Ніна", "Наталія",
                "Ольга", "Олена", "Раїса", "Світлана", "Сусанна",
                "Тетяна", "Юлія", "Яна", "Ярослава", "Софія", "Стелла", "Сара",
                "Нонна", "Олександра"};
            string[] jobs = {"Лікар","Пожежник","Програміст","Медик",
                "Будівельник", "Блогер", "Фотограф", "Вебмайстер", "Репетитор",
                "Професійний геймер", "Дизайнер", "Трейдер", "Журналіст", "Агент", "Біоетика",
                "Столяр", "Тесляр", "Скляр","Перекладач", "Боцман", "Художник",
                "Аніматор", "Акробат", "Гончар", "Філософ", "Фототехнік",
                "Жонглер", "Вокаліст", "Кінолог", "Декан", "Директор школи",
                "Зварювальник", "Бджоляр", "Кравець", "Каскадер", "Безробітній"};
            string[] hobbys = {"Рибалка", "Бокс", "Футбол", "хокей", "баскетбол",
            "регбі", "теніс", "бадмінтон", "настільний теніс", "йога", "велоспорт",
                "Графіка", "Живопис", "Шиття", "Ліплення", "Кулінарія", "Шахи",
                "Доміно", "Нарди", "Маджонг", "Покер", "Література", "Нетбол",
                "Більярд", "Боулінг", "Пейнтбол", "Паркур", "Гольф", "Дайвінг",
                "Фітнес", "Плавання", "Дартс", "Ролики", "Ковзани", "Археологія",
                "Медитація"};
            string[] natures = {"Веселий", "Оптимістичний", "Відкритий", "М'який", "Спокійний",
                "Терплячий", "Серйозний", "Врівноважений", "Сумний", "Меланхолійний",
                "Несерйозний", "Песимістичний", "Замкнутий", "Злісний", "Агресивний",
                "Мовчазний", "Агресивний", "Запальний", "Суворий", "Строгий", "Непокірний" };
            string[] orientations = {"Гетеросексуальність", "Гомосексуальність",
                "Бісексуальність", "Асексуальні"};

            if (random.Next(1, 3) == 1)
            {
                player = new Man(namesM[random.Next(0, namesM.Length)],
                jobs[random.Next(0, jobs.Length)],
                hobbys[random.Next(0, hobbys.Length)],
                natures[random.Next(0, natures.Length)],
                orientations[random.Next(0, orientations.Length)]);
            }
            else
            {
                player = new Women(namesW[random.Next(0, namesM.Length)],
                jobs[random.Next(0, jobs.Length)],
                hobbys[random.Next(0, hobbys.Length)],
                natures[random.Next(0, natures.Length)],
                orientations[random.Next(0, orientations.Length)]);
            }

            return player;
        }
    }
}

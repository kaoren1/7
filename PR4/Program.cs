using System.Runtime.InteropServices;

namespace PR4
{
    internal class Program
    {
        public static void Main()
        {
            DateTime d = new DateTime(2023, 10, 16);
            ConsoleKeyInfo a = Console.ReadKey();
            while (a.Key != ConsoleKey.Enter)
            {
                while (a.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    d = d.AddDays(1);
                    if (d.Date == new DateTime(2023, 10, 16).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Note1();
                        }
                        Console.Clear();
                    }
                    else if (d.Date == new DateTime(2023, 10, 18).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Note2();
                        }
                        Console.Clear();
                    }
                    else if (d.Date == new DateTime(2023, 10, 7).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Note3();
                        }
                        Console.Clear();
                    }
                    Console.WriteLine(d);
                    a = Console.ReadKey();
                }
                while (a.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    d = d.AddDays(-1);
                    if (d.Date == new DateTime(2023, 10, 16).Date)
                    {
                        Console.WriteLine(d);
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Note1();
                        }
                        Console.Clear();
                    }
                    else if (d.Date == new DateTime(2023, 10, 18).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Note2();
                        }
                        Console.Clear();
                    }
                    else if (d.Date == new DateTime(2023, 10, 7).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Note3();
                        }
                        Console.Clear();
                    }
                    Console.WriteLine(d);
                    a = Console.ReadKey();
                }
            }
        }
        public static void Note1()
        {
            Console.WriteLine("Дата: 16.10.2023");
            Console.WriteLine("  1. Сходить на пары");
            Console.WriteLine("  2. Сходить покушать");
            Console.WriteLine("  3. Сходить погулять");
            int selected = Cursor();

            if (selected == 1)
            {
                Console.Clear();
                Note den1 = new Note();
                den1.Name = "Сходить на пары";
                den1.Description = "Самый обычный день в МПТ";
                den1.Date = "16.10.2023";
                Console.WriteLine("Название: " + den1.Name);
                Console.WriteLine("Описание: " + den1.Description);
                Console.WriteLine("Дата: " + den1.Date);
            }
            else if (selected == 2)
            {
                Console.Clear();
                Note den2 = new Note();
                den2.Name = "Сходить покушать";
                den2.Description = "Было очень вкусно";
                den2.Date = "16.10.2023";
                Console.WriteLine("Название: " + den2.Name);
                Console.WriteLine("Описание: " + den2.Description);
                Console.WriteLine("Дата: " + den2.Date);
            }
            else if (selected == 3)
            {
                Console.Clear();
                Note den3 = new Note();
                den3.Name = "Сходить погулять";
                den3.Description = "Было очень интересно";
                den3.Date = "16.10.2023";
                Console.WriteLine("Название: " + den3.Name);
                Console.WriteLine("Описание: " + den3.Description);
                Console.WriteLine("Дата: " + den3.Date);
            }
            Program.Main();
        }
        public static void Note2()
        {
            Console.WriteLine("Дата: 18.10.2023");
            Console.WriteLine("  1. Сходить на фестиваль");
            Console.WriteLine("  2. Погулять по парку");
            Console.WriteLine("  3. Сходить на др");
            int selected = Cursor();

            if (selected == 1)
            {
                Console.Clear();
                Note den4 = new Note();
                den4.Name = "Сходить на фестиваль";
                den4.Description = "Мне очень понравилось";
                den4.Date = "18.10.2023";
                Console.WriteLine("Название: " + den4.Name);
                Console.WriteLine("Описание: " + den4.Description);
                Console.WriteLine("Дата: " + den4.Date);
                Program.Main();
            }
            else if (selected == 2)
            {
                Console.Clear();
                Note den8 = new Note();
                den8.Name = "Погулять по парку";
                den8.Description = "Парк очень красивый";
                den8.Date = "18.10.2023";
                Console.WriteLine("Название: " + den8.Name);
                Console.WriteLine("Описание: " + den8.Description);
                Console.WriteLine("Дата: " + den8.Date);
            }
            else if (selected == 3)
            {
                Console.Clear();
                Note den9 = new Note();
                den9.Name = "Сходить на др";
                den9.Description = "Я вкусно покушал";
                den9.Date = "18.10.2023";
                Console.WriteLine("Название: " + den9.Name);
                Console.WriteLine("Описание: " + den9.Description);
                Console.WriteLine("Дата: " + den9.Date);
            }
            Program.Main();
        }
        public static void Note3()
        {
            Console.WriteLine("Дата: 07.10.2023");
            Console.WriteLine("  1. Сходить в боулинг");
            Console.WriteLine("  2. Сходить в бильярд");
            Console.WriteLine("  3. Сходить в компьтерный клуб");
            int selected = Cursor();

            if (selected == 1)
            {
                Console.Clear();
                Note den5 = new Note();
                den5.Name = "Сходить в боулинг";
                den5.Description = "Я выиграл";
                den5.Date = "07.10.2023";
                Console.WriteLine("Название: " + den5.Name);
                Console.WriteLine("Описание: " + den5.Description);
                Console.WriteLine("Дата: " + den5.Date);
            }
            else if (selected == 2)
            {
                Console.Clear();
                Note den6 = new Note();
                den6.Name = "Сходить в бильярд";
                den6.Description = "Я выиграл";
                den6.Date = "07.10.2023";
                Console.WriteLine("Название: " + den6.Name);
                Console.WriteLine("Описание: " + den6.Description);
                Console.WriteLine("Дата: " + den6.Date);
            }
            else if (selected == 3)
            {
                Console.Clear();
                Note den7 = new Note();
                den7.Name = "Сходить в компьютерный клуб";
                den7.Description = "Я выиграл";
                den7.Date = "07.10.2023";
                Console.WriteLine("Название: " + den7.Name);
                Console.WriteLine("Описание: " + den7.Description);
                Console.WriteLine("Дата: " + den7.Date);
            }
            Program.Main();
        }
        public static int Cursor()
        {
            ConsoleKeyInfo key;
            int pos = 2;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != 3)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != 5)
                {
                    pos++;
                }
            }
            while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}


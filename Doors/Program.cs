using System;
using System.IO;

namespace Doors
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DoorsCalc doorsCalc = new DoorsCalc();
            ServiceCalc serviceCalc = new ServiceCalc();
            SeparatelyDoorsCalc separatelyDoorsCalc = new SeparatelyDoorsCalc();

            //Главное меню
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\tРАСЧЕТ ОБЩЕЙ СУММЫ МЕЖКОМНАТНЫХ ДВЕРЕЙ И УСЛУГ МОНТАЖА.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  Рассчитать только (Полотна F1) (Коробы F2) (Наличники F3) (Ручки F4) (Замки F5) (Петли F6) (Фиксаторы F7) (Доборы F8)");
            Console.WriteLine();
            Console.WriteLine("\t\t!!!Рассчитать весь комплект Enter.\t\t|\t\tРасчет только Услуги монтажа F9.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            //Исполнение главного меню
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    //Полный расчет межк дверей
                    case ConsoleKey.Enter:
                        Console.WriteLine("\t\t\t\t\tРАСЧЕТ КОМПЛЕКТА МЕЖКОМНАТНЫХ ДВЕРЕЙ:");
                        Console.WriteLine();
                        doorsCalc.Print();
                        Console.WriteLine();
                        break;
                    //Расчет только полотен
                    case ConsoleKey.F1:
                        Console.WriteLine("\t\t\t\t\tРАСЧЕТ ПОЛОТЕН:");
                        double doorLeaf;
                        separatelyDoorsCalc.doorLeafFoo(0, 0, out doorLeaf);
                        Console.WriteLine();
                        break;
                    //Расчет только коробов
                    case ConsoleKey.F2:
                        Console.WriteLine("\t\t\t\t\tРАСЧЕТ КОРОБОВ:");
                        double doorBox;
                        separatelyDoorsCalc.doorBoxFoo(0, 0, out doorBox);
                        break;
                    //Расчет только наличников
                    case ConsoleKey.F3:
                        Console.WriteLine("\t\t\t\t\tРАСЧЕТ НАЛИЧНИКОВ:");
                        double doorFrame;
                        separatelyDoorsCalc.doorFrameFoo(0, 0, out doorFrame);
                        break;
                    //Расчет только ручек
                    case ConsoleKey.F4:
                        Console.WriteLine("\t\t\t\t\tРАСЧЕТ ДВЕРНЫХ РУЧЕК:");
                        double doorKnob;
                        separatelyDoorsCalc.doorKnobFoo(0, 0, out doorKnob);
                        break;
                    //Расчет только замков
                    case ConsoleKey.F5:
                        Console.WriteLine("\t\t\t\t\tРАСЧЕТ ДВЕРНЫХ ЗАМКОВ:");
                        double doorLock;
                        separatelyDoorsCalc.doorLockFoo(0, 0, out doorLock);
                        break;
                    //Расчет только петель
                    case ConsoleKey.F6:
                        Console.WriteLine("\t\t\t\t\tРАСЧЕТ ДВЕРНЫХ ПЕТЕЛЬ:");
                        double doorHinges;
                        separatelyDoorsCalc.doorHingesFoo(0, 0, out doorHinges);
                        break;
                    //Расчет только фиксаторов
                    case ConsoleKey.F7:
                        Console.WriteLine("\t\t\t\t\tРАСЧЕТ ДВЕРНЫХ ФИКСАТОРОВ:");
                        double doorStriker;
                        separatelyDoorsCalc.doorStrikerFoo(0, 0, out doorStriker);
                        break;
                    //Расчет только доборов
                    case ConsoleKey.F8:
                        Console.WriteLine("\t\t\t\t\tРАСЧЕТ ДОБОРОВ:");
                        double doorExtensions;
                        separatelyDoorsCalc.doorExtensionsFoo(0, 0, out doorExtensions);
                        break;
                    //Расчет только монтажа
                    case ConsoleKey.F9:
                        Console.WriteLine("Нужен ли клиенту монтаж? Да F9, Нет ПРОБЕЛ");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\tРАСЧЕТ МОНТАЖНЫХ РАБОТ:");
                        Console.WriteLine();
                        serviceCalc.Service();
                        Console.WriteLine();
                        break;
                    //Завершение работы
                    case ConsoleKey.Spacebar:
                        Console.WriteLine("Завершение работы.");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                
                //Данные о клиенте
                try
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\t\t\t\t\tЗАПИСЬ КЛИЕНТА НА ЗАМЕР");
                    Console.WriteLine();
                    Console.WriteLine("Ведите ФИО, Телефон и Адрес клиента клиента: (Пропустить данный шаг - Enter)");
                    string fio = Console.ReadLine();
                    File.WriteAllText(@"C:\Users\darka\Desktop\\DoorsSQL.txt", fio);
                }

                catch (Exception)
                {
                    Console.WriteLine("Завершение данной операции. Выберите следующие пункты меню.");
                }

                //Повтор главного меню
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("  Рассчитать только (Полотна F1) (Коробы F2) (Наличники F3) (Ручки F4) (Замки F5) (Петли F6) (Фиксаторы F7) (Доборы F8)");
                Console.WriteLine();
                Console.WriteLine("\t\t!!!Рассчитать весь комплект Enter.\t\t|\t\tРасчет только Услуги монтажа F9.");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
            } 
        }
    }
}

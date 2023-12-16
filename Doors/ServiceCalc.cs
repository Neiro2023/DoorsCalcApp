using System;

namespace Doors
{
    internal class ServiceCalc
    {

        public double delivery; // Доставка
        public double skidding; // Подьем
        public double montage; // Монтаж
        public double demontage; //Демонтаж
        public double inset;// Врезка замка
        public double equipment;// Монтаж добора
        public double dissolution; // Росспуск добора
        public  void Service()
        {
            try {  
                //Доставка
                Console.Write("Введите сумму ДОСТАВКИ: ");
                double doorLeafSumm = double.Parse(Console.ReadLine());
                double delivery = doorLeafSumm;
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА ДОСТАВКИ {delivery} р.)");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                //Подъем\Этаж
                Console.Write("Введите колличество ЭТАЖЕЙ: ");
                double skiddingCount = double.Parse(Console.ReadLine());
                Console.Write("Введите сумму ПОДЪЕМА: ");
                double skiddingSumm = double.Parse(Console.ReadLine());
                double skidding = skiddingCount * skiddingSumm;
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА ПОДЬЕМА {skidding} р.)");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                //Монтаж
                Console.Write("Введите колличество МОНТАЖА: ");
                double montageCount = double.Parse(Console.ReadLine());
                Console.Write("Введите сумму МОНТАЖА: ");
                double montageSumm = double.Parse(Console.ReadLine());
                double montage = montageCount * montageSumm;
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА МОНТАЖА {montage} р.)");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                //Демонтаж
                Console.Write("Введите колличество ДЕМОНТАЖА: ");
                double demontageCount = double.Parse(Console.ReadLine());
                Console.Write("Введите сумму ДЕМОНТАЖА: ");
                double demontageSumm = double.Parse(Console.ReadLine());
                double demontage = montageCount * montageSumm;
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА МОНТАЖА {montage} р.)");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                //Врезка замка
                Console.Write("Введите колличество ВРЕЗОК ЗАМКА: ");
                double insetCount = double.Parse(Console.ReadLine());
                Console.Write("Введите сумму ВРЕЗКИ ЗАМКА: ");
                double insetSumm = double.Parse(Console.ReadLine());
                double inset = insetCount * insetSumm;
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА ВРЕЗКИ ЗАМКА {inset} р.)");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                //Монтаж доборов
                Console.Write("Введите колличество МОНТАЖЕЙ ДОБОРА: ");
                double equipmentCount = double.Parse(Console.ReadLine());
                Console.Write("Введите сумму МОНТАЖА ДОБОРА: ");
                double equipmentSumm = double.Parse(Console.ReadLine());
                double equipment = equipmentCount * equipmentSumm;
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА МОНТАЖА ДОБОРА {equipment} р.)");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                //Росспуск добора
                Console.Write("Введите колличество РОССПУСКА ДОБОРА: ");
                double dissolutiontCount = double.Parse(Console.ReadLine());
                Console.Write("Введите сумму РОСПУСКА ДОБОРА: ");
                double dissolutiontSumm = double.Parse(Console.ReadLine());
                double dissolution = dissolutiontCount * dissolutiontSumm;
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА РОССПУСКА ДОБОРА {dissolution} р.)");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                //Общая сумма монтажа
                Console.WriteLine();
                double total = delivery + skidding + montage + demontage + inset + equipment + dissolution;
                Console.WriteLine($"-- ИТОГО: ОБЩАЯ СУММА МОНТАЖА РАВНА {total}р --"); 
            }
            catch (Exception)
            {
                Console.WriteLine("Неверная операция");
            }

        }
    }
}

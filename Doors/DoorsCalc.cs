using System;

namespace Doors
{
    internal class DoorsCalc
    {
        
        public double doorLeaf; // Полотко
        public double doorBox; // Короб
        public double doorFrame; // Наличники
        public double doorKnob;// Ручки
        public double doorLock;// Замок
        public double doorHinges; // Петли
        public double doorStriker; // Фиксатор
        public double doorExtensions; // Доборы
        
        public void Print()
        {

            try
            {
                //Полотно
                Console.Write("Введите количество ПОЛОТЕН: ");
                double doorLeafCount = double.Parse(Console.ReadLine());
                Console.Write("Введите стоимость одного ПОЛОТЕНА: ");
                double doorLeafSumm = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА ПОЛОТЕН {doorLeafCount * doorLeafSumm} р.)");
                double totalSummLeaf = doorLeafCount * doorLeafSumm;
                double doorLeaf = totalSummLeaf;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                // Короб
                Console.WriteLine($"ШПАРГАЛКА. На {doorLeafCount} полотен приходится {doorLeafCount * 2.5} коробов");
                Console.WriteLine();
                Console.Write("Введите количество КОРОБОВ: ");
                double doorBoxCount = double.Parse(Console.ReadLine());
                Console.Write("Введите стоимость одного КОРОБА: ");
                double doorBoxSumm = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА КОРОБОВ {doorBoxCount * doorBoxSumm} р.)");
                double totalSummBox = doorBoxCount * doorBoxSumm;
                double doorBox = totalSummBox;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                // Наличники
                Console.Write("Укажите колличество дверей с НАЛИЧНИКАМИ с одной стороны: (Если нет, то 0) ");
                double doorFrameCountOne = double.Parse(Console.ReadLine());
                Console.Write($"Укажите колличество дверей с НАЛИЧНИКАМИ с обоих сторон (их {doorLeafCount - doorFrameCountOne}): (Если нет, то 0) ");
                double doorFrameCountBoth = double.Parse(Console.ReadLine());
                double doorFrameCount = doorFrameCountOne * 2.5 + doorFrameCountBoth * 5;
                Console.Write("Введите стоимость одного НАЛИЧНИКА: ");
                double doorFrameSumm = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА НАЛИЧНИКОВ {doorFrameCount * doorFrameSumm} р.)");
                double totalSummFrame = doorFrameCount * doorFrameSumm;
                double doorFrame = totalSummFrame;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                
                // Ручки
                Console.WriteLine($"ШПАРГАЛКА. На {doorLeafCount} полотен приходится {doorLeafCount * 1} ручек");
                Console.WriteLine();
                Console.Write("Введите количество РУЧЕК: ");
                double doorKnobCount = double.Parse(Console.ReadLine());
                Console.Write("Введите стоимость комплекта РУЧЕК: ");
                double doorKnobSumm = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА РУЧЕК {doorKnobCount * doorKnobSumm} р.)");
                double totalSummKnob = doorKnobCount * doorKnobSumm;
                double doorKnob = totalSummKnob;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                // Замок
                Console.WriteLine($"ШПАРГАЛКА. На {doorLeafCount} полотен приходится {doorLeafCount * 1} замков");
                Console.WriteLine();
                Console.Write("Введите количество ЗАМКОВ: ");
                double doorLockCount = double.Parse(Console.ReadLine());
                Console.Write("Введите стоимость одного ЗАМКА: ");
                double doorLockSumm = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА ЗАМКОВ {doorLockCount * doorLockSumm} р.)");
                double totalSummLock = doorLockCount * doorLockSumm;
                double doorLock = totalSummLock;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                // Петли
                Console.WriteLine($"ШПАРГАЛКА. На {doorLeafCount} полотен приходится {doorLeafCount * 2} петель");
                Console.WriteLine();
                Console.Write("Введите количество ПЕТЕЛЬ: ");
                double doorHingesCount = double.Parse(Console.ReadLine());
                Console.Write("Введите стоимость одной ПЕТЛИ: ");
                double doorHingesSumm = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА ПЕТЛЕЙ {doorHingesCount * doorHingesSumm} р.)");
                double totalSummHinges = doorHingesCount * doorHingesSumm;
                double doorHinges = totalSummHinges;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                // Фиксатор
                Console.WriteLine($"ШПАРГАЛКА. На {doorLeafCount} полотен приходится {doorLeafCount * 1} фиксаторов");
                Console.WriteLine();
                Console.Write("Введите количество ФИКСАТОРОВ: ");
                double doorStrikerCount = double.Parse(Console.ReadLine());
                Console.Write("Введите стоимость одного ФИКСАТОРА: ");
                double doorStrikerSumm = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА ФИКСАТОРОВ {doorStrikerCount * doorStrikerSumm} р.)");
                double totalSummStriker = doorStrikerCount * doorStrikerSumm;
                double doorStriker = totalSummStriker;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                // Доборы
                Console.Write("Введите количество ДОБОРОВ: ");
                double doorExtensionsCount = double.Parse(Console.ReadLine());
                Console.Write("Введите стоимость одного ДОБОРА: ");
                double doorExtensionsSumm = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t(СУММА ДОБОРОВ {doorExtensionsCount * doorExtensionsSumm} р.)");
                double totalSummExtensions = doorExtensionsCount * doorExtensionsSumm;
                double doorExtensions = totalSummExtensions;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                
                //Расчет общей стоимости
                double totalAmountDoors = doorLeaf + doorBox + doorFrame + doorKnob + doorLock + doorHinges + doorStriker + doorExtensions;

                //Итоговый расчет с выводом позоций в консоль
                Console.WriteLine();
                Console.WriteLine("\t\t\t\tИТОГОВЫЙ РАСЧЕТ КОМПЛЕКТА ДВЕРЕЙ.");
                Console.WriteLine();
                Console.WriteLine($" ИТОГО: ВЕСЬ КОМПЛЕКТ СОСТОЯВЛЯЕТ -- ({totalAmountDoors})рублей. --");
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            }

            catch(Exception)
            {
                Console.WriteLine("Завершение предыдущей операции");
            }
        }  
    }
}

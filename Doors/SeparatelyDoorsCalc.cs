using System;

namespace Doors
{
    internal class SeparatelyDoorsCalc
    {
        public void doorLeafFoo(double doorLeafCount, double doorLeafSumm, out double doorLeaf)
        {   //Полотно
            Console.Write("Введите количество ПОЛОТЕН:  ");
            doorLeafCount = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость одного ПОЛОТЕНА:  ");
            doorLeafSumm = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"(СУММА ПОЛОТЕН {doorLeafCount * doorLeafSumm} р.)");
            doorLeaf = doorLeafCount * doorLeafSumm;
        }
        public void doorBoxFoo(double doorBoxCount, double doorBoxSumm, out double doorBox)
        {
            // Короб
            Console.Write("Введите количество КОРОБОВ: ");
            doorBoxCount = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость одного КОРОБА: ");
            doorBoxSumm = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"(СУММА КОРОБОВ {doorBoxCount * doorBoxSumm} р.)");
            doorBox = doorBoxCount * doorBoxSumm;
        }
        public void doorFrameFoo(double doorFrameCount, double doorFrameSumm, out double doorFrame)
        {
            // Наличники
            Console.Write("Введите количество НАЛИЧНИКОВ: ");
            doorFrameCount = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость одного НАЛИЧНИКА: ");
            doorFrameSumm = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"(СУММА НАЛИЧНИКОВ {doorFrameCount * doorFrameSumm} р.)");
            doorFrame = doorFrameCount * doorFrameSumm;
        }
        public void doorKnobFoo(double doorKnobCount, double doorKnobSumm, out double doorKnob)
        {
            // Ручки
            Console.Write("Введите количество РУЧЕК: ");
            doorKnobCount = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость комплекта РУЧЕК: ");
            doorKnobSumm = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"(СУММА РУЧЕК {doorKnobCount * doorKnobSumm} р.)");
            doorKnob = doorKnobCount * doorKnobSumm;
        }
        public void doorLockFoo(double doorLockCount, double doorLockSumm, out double doorLock)
        {
            // Замок
            Console.Write("Введите количество ЗАМКОВ: ");
            doorLockCount = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость одного ЗАМКА: ");
            doorLockSumm = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"(СУММА ЗАМКОВ {doorLockCount * doorLockSumm} р.)");
            doorLock = doorLockCount * doorLockSumm;
        }
        public void doorHingesFoo(double doorHingesCount, double doorHingesSumm, out double doorHinges)
        {
            // Петли
            Console.Write("Введите количество ПЕТЕЛЬ: ");
            doorHingesCount = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость одной ПЕТЛИ: ");
            doorHingesSumm = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"(СУММА ПЕТЛЕЙ {doorHingesCount * doorHingesSumm} р.)");
            doorHinges = doorHingesCount * doorHingesSumm;
        }
        public void doorStrikerFoo(double doorStrikerCount, double doorStrikerSumm, out double doorStriker)
        {
            // Фиксатор
            Console.Write("Введите количество ФИКСАТОРОВ: ");
            doorStrikerCount = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость одного ФИКСАТОРА: ");
            doorStrikerSumm = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"(СУММА ФИКСАТОРОВ {doorStrikerCount * doorStrikerSumm} р.)");
            doorStriker = doorStrikerCount * doorStrikerSumm;
        }
        public void doorExtensionsFoo(double doorExtensionsCount, double doorExtensionsSumm, out double doorExtensions)
        {
            // Доборы
            Console.Write("Введите количество ДОБОРОВ: ");
            doorExtensionsCount = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость одного ДОБОРА: ");
            doorExtensionsSumm = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"(СУММА ДОБОРОВ {doorExtensionsCount * doorExtensionsSumm} р.)");
            doorExtensions  = doorExtensionsCount * doorExtensionsSumm;
        }
    }
}

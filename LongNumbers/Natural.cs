using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMath
{
    class Natural
    {
        private ushort n; // номер старшей позиции
        private List<ushort> numbers; // массив цифр

        public Natural()
        {
            n = 0;
            numbers = new List<ushort>();
        }

        public Natural(ushort n, List<ushort> numbers)
        {
            this.n = n;
            this.numbers = numbers;
        }

        // Сравнение натуральных чисел: 2 - если первое больше второго, 0, если равно, 1 иначе.
        private static int COM_NN_N(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // Проверка на ноль: если число не равно нулю, то «да» иначе «нет»
        public bool NZER_N_B()
        {
            throw new NotImplementedException();
        }

        //Добавление 1 к натуральному числу
        public Natural ADD_1N_N()
        {
            throw new NotImplementedException();
        }

        //Сложение натуральных чисел
        public static Natural ADD_NN_N(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        //Вычитание из первого большего натурального числа второго меньшего или равного
        public static Natural SUB_NN_N(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // Умножение натурального числа на цифру
        private static Natural MUL_ND_N(Natural a, int b)
        {
            throw new NotImplementedException();
        }

        // Умножение натурального числа на 10^k
        private static Natural MUL_Nk_N(Natural a, int k)
        {
            throw new NotImplementedException();
        }

        //Умножение натуральных чисел
        private static Natural MUL_NN_N(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // Вычитание из натурального другого натурального, 
        // умноженного на цифру для случая с неотрицательным результатом
        public static Natural SUB_NDN_N(Natural a, Natural b, int num)
        {
            throw new NotImplementedException();
        }

        // ! Требует уточнения
        //Вычисление первой цифры деления большего натурального на меньшее, домноженное на 10^k, где k - номер позиции этой цифры(номер считается с нуля)
        public static int DIV_NN_Dk(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // Частное от деления большего натурального числа на меньшее или равное натуральное с остатком (делитель отличен от нуля)
        private static Natural DIV_NN_N(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        //  Остаток от деления большего натурального числа на меньшее или равное натуральное с остатком (делитель отличен от нуля)
        private static Natural MOD_NN_N(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // НОД натуральных чисел
        public static Natural GCF_NN_N(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // НОК натуральных чисел
        public static Natural LCM_NN_N(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // должен использовать COM_NN_N
        public static bool operator > (Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // должен использовать COM_NN_N
        public static bool operator < (Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // должен использовать COM_NN_N
        public static bool operator ==(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // должен использовать COM_NN_N
        public static bool operator !=(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // должен использовать ADD_NN_N
        public static Natural operator +(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // должен использовать SUB_NDN_N
        public static Natural operator -(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // должен использовать MUL_NN_N
        public static Natural operator * (Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // должен использовать MUL_ND_N
        public static Natural operator *(Natural a, int b)
        {
            throw new NotImplementedException();
        }

        // должен использовать DIV_NN_N
        public static Natural operator /(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // должен использовать MOD_NN_N
        public static Natural operator %(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // метод преобразования в строку - для вывода
        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}

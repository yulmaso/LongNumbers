using System;
using System.Collections.Generic;

namespace LongNumbers
{
    class Natural
    {
        private int n; // номер старшей позиции
        private List<ushort> digits; // массив цифр

        public Natural()
        {
            n = 1;
            digits = new List<ushort> { 0 };
        }

        public Natural(List<ushort> numbers)
        {
            this.digits = numbers;
            n = numbers.Count;
        }

        public Natural(long number)
        {
            if (number < 0)
                throw new ArgumentException("Argument must be positive");
            List<ushort> digits = new List<ushort>();
            while (number != 0)
            {
                digits.Add(Convert.ToUInt16(number % 10));
                number /= 10;
            }
            this.digits = digits;
            this.n = digits.Count;
        }

        // Выполнил Шутемов А.А.
        // Сравнение натуральных чисел: 2 - если первое больше второго, 0, если равно, 1 иначе.
        private static int COM_NN_N(Natural a, Natural b)
        {
            int buff = 0, buff1 = 0, counter = 0; //buff,buff1 хранят количество разрядов в числе a и b соответственно
            string c = Convert.ToString(a);
            string c1 = Convert.ToString(b);

            buff = c.Length;
            buff1 = c1.Length;

            if (buff > buff1)                      //проверка на количество разрядов, если у а больше, то return 2
                return 2;

            else if (buff == buff1)                //если количество разрядов равны, то проверяем по старшим разрядам,
            {                                      //пока один из разрядов не окажется меньшим/большим, чем такой же разряд
                for (int i = 0; i < buff; i++)     // второго числа
                {
                    if (c[i] == c1[i])
                    {
                        counter++;
                        continue;
                    }
                    else if (counter == buff)
                        return 0;
                    else if (c[i] > c1[i])
                        return 2;
                    else
                        return 1;
                }
            }
            else
                return 1;
            return 0;
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

        //Вычисление первой цифры деления большего натурального на меньшее, домноженное на 10^k, где k - номер позиции этой цифры(номер считается с нуля)
        public static Natural DIV_NN_Dk(Natural a, Natural b)
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
            string result = "";
            for (int i = n - 1; i >= 0; i--)
            {
                result += digits[i].ToString();
            }
            return result;
        }

    }
}

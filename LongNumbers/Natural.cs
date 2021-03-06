﻿using System;
using System.Collections.Generic;

namespace LongNumbers
{
    class Natural
    {
        private int n; // номер старшей позиции
        private List<ushort> digits; // массив цифр,  0 индекс - самый младший разряд

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

        public Natural(Natural a)
        {
            this.digits = new List<ushort>(a.digits);
            this.n = a.n;
        }

        // Выполнил Шутемов А.А.
        // Сравнение натуральных чисел: 2 - если первое больше второго, 0, если равно, 1 иначе.
        private static int COM_NN_N(Natural a, Natural b)
        {
            if (a.n > b.n)                      //проверка на количество разрядов, если у а больше, то return 2
                return 2;

            else if (a.n == b.n)                //если количество разрядов равны, то проверяем по старшим разрядам,
            {                                      //пока один из разрядов не окажется меньшим/большим, чем такой же разряд
                for (int i = a.digits.Count - 1; i >=0; i--)     // второго числа
                {
                    if (a.digits[i] > b.digits[i])
                        return 2;
                    else if (a.digits[i] < b.digits[i])
                        return 1;
                    else
                        continue;
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
        //Выполнил Медведев
        public static Natural ADD_NN_N(Natural a, Natural b)
        {
            Natural c = new Natural(a);
            Natural d = new Natural(b);

            if (Natural.COM_NN_N(a, b) == 1)
            {
                c = new Natural(b);
                d = new Natural(a);
            }
            ushort s = 0;//це остаток 
            ushort k = 0;//це сумма разрядов
            int i = 0;
            for (i = 0; i < d.n; i++)
            {
                k = (ushort)(c.digits[i] + d.digits[i] + s);//сумма разрядов и остатка от сложения предыдущих 
                c.digits[i] = (ushort)(k % 10);//тут короче присваевваем наканецта 
                s = (ushort)(k / 10);//тут вычисляем остаток(типо 7+7=14,такой цифры нет,Kappa) 
            }
            i = d.n;
            while (s != 0)//проверка последнего такого остаточка 
            {

                if (c.n != i)//если разряды не кончились 
                {

                    k = (ushort)(c.digits[i] + s);
                    c.digits[i] = (ushort)(k % 10);//если он есть,то мы влетаем и спасаем ситуацию 
                    s = (ushort)(k / 10);
                    i++;
                }
                else//а тута если кончились 
                {
                    c.digits.Add(1);//вот тут спасаем 
                    c.n++;
                    s = 0;
                };
            }
            return c;//даем понять,шо все гатова
        }

        //Вычитание из первого большего натурального числа второго меньшего или равного
        public static Natural SUB_NN_N(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // Умножение натурального числа на цифру
        // Выполнил Медведев
        private static Natural MUL_ND_N(Natural a, int b)
        {
            Natural c = new Natural(a);
            if (b == 0)
            {
                c.n = 1;
                c.digits[0] = 0;
                return c;
            }
            else
            {
                int s = 0;
                ushort k = 0;
                for (int i = 0; i < c.n; i++)
                {
                    k = (ushort)(c.digits[i] * b + s);//тут разряд умножаем на цифирку 
                    c.digits[i] = (ushort)(k % 10);//тут короче присваевваем наканецта 
                    s = (ushort)(k / 10);//тут вычисляем остаток(типо 7+7=14,такой цифры нет,Kappa) 
                }
                if (s != 0)//проверка последнего такого остаточка 
                {
                    //если он есть,то мы влетаем и спасаем ситуацию 
                    c.digits.Add((ushort)(s));//вот тут спасаем 
                    c.n++;//естественно,увеличиваем,чем больше-тем лучше 
                }
                return c;//даем понять,шо все гатова 
            }
        }

        // Умножение натурального числа на 10^k
        // Выполнил Медведев
        public static Natural MUL_Nk_N(Natural a, int k)
        {
            Natural c = new Natural(a);
            c.n += k;
            for (int i = 0; i < k; i++)
            {
                c.digits.Insert(0, 0);//типо нулик в конец суем 
            }
            //естественно,увеличиваем,чем больше-тем лучше 
            return c;//возвращаем то,шо забрали
        }

        // Умножение натуральных чисел
        // Выполнил Медведев
        private static Natural MUL_NN_N(Natural a, Natural b)
        {
            Natural c = new Natural(a);
            Natural temp = new Natural(0);
            for (int i = 0; i < b.n; i++)
            {
                temp = Natural.ADD_NN_N(temp, Natural.MUL_Nk_N(Natural.MUL_ND_N(c, b.digits[i]), i));//тут многа букаф,но поверьте,це робет 
            }
            return temp;
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
        public static bool operator >(Natural a, Natural b)
        {
            return COM_NN_N(a, b) == 2;
        }

        // должен использовать COM_NN_N
        public static bool operator <(Natural a, Natural b)
        {
            return COM_NN_N(a, b) == 1;
        }

        // должен использовать COM_NN_N
        public static bool operator ==(Natural a, Natural b)
        {
            return COM_NN_N(a, b) == 0;
        }

        // должен использовать COM_NN_N
        public static bool operator !=(Natural a, Natural b)
        {
            return !(a == b);
        }

        // должен использовать ADD_NN_N
        public static Natural operator +(Natural a, Natural b)
        {
            return ADD_NN_N(a, b);
        }

        // должен использовать SUB_NDN_N
        public static Natural operator -(Natural a, Natural b)
        {
            throw new NotImplementedException();
        }

        // должен использовать MUL_NN_N
        public static Natural operator *(Natural a, Natural b)
        {
            return MUL_NN_N(a, b);
        }

        // должен использовать MUL_ND_N
        public static Natural operator *(Natural a, int b)
        {
            return MUL_ND_N(a, b);
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
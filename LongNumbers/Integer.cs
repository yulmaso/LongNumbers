using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongNumbers
{
    class Integer
    {
        private bool sign; // знак числа, true - "+", false - "-"
        Natural number; // натуральное число или нуль

        public Integer()
        {
            sign = true;
            number = new Natural();
        }

        public Integer(bool sign, List<ushort> digits)
        {
            this.sign = sign;
            number = new Natural(digits);
        }

        public Integer (Natural number)
        {
            sign = true;
            this.number = number;
        }

        public Integer(long number)
        {
            if (number < 0)
                sign = false;
            else
                sign = true;
            this.number = new Natural(Math.Abs(number));
        }

        //Абсолютная величина числа, результат - натуральное 
        //Шутемов А.А.
        public static Natural ABS_Z_N(Integer a)
        {
            Natural b;
            b = a.number;
            return b;
        }

        // Определение положительности числа (2 - положительное, 0 — равное нулю, 1 - отрицательное)
        public static int POZ_Z_D(Integer a)
        {
            throw new NotImplementedException();
        }

        // Умножение целого на (-1)
        // Шутемов А.А.
        public Integer MUL_ZM_Z(Integer a)
        {
            if (!a.sign)
            {
                a.sign = false;
                return a;
            }
            else
            {
                a.sign = true;
                return a;
            }
        }

        // Преобразование натурального в целое
        // Выполнил Шутемов А.А.
        public static Integer TRANS_N_Z(Natural a)
        {
            Integer temp = new Integer();
            temp.sign = true;
            temp.number = a;
            return temp;
        }

        // Преобразование целого неотрицательного в натуральное
        public static Natural TRANS_Z_N(Integer a)
        {
            throw new NotImplementedException();
        }

        // Сложение целых чисел
        public static Integer ADD_ZZ_Z(Integer a, Integer b)
        {
            throw new NotImplementedException();
        }

        // Вычитание целых чисел
        public static Integer SUB_ZZ_Z(Integer a, Integer b)
        {
            throw new NotImplementedException();
        }

        // Умножение целых чисел
        public static Integer MUL_ZZ_Z(Integer a, Integer b)
        {
            throw new NotImplementedException();
        }

        // Частное от деления большего целого числа на меньшее или равное натуральное с остатком
        public static Integer DIV_ZZ_Z(Integer a, Integer b)
        {
            throw new NotImplementedException();
        }

        // Остаток от деления большего целого числа на меньшее или равное натуральное с остатком
        public static Integer MOD_ZZ_Z(Integer a, Integer b)
        {
            throw new NotImplementedException();
        }

        // должен использовать ADD_ZZ_Z
        public static Integer operator + (Integer a, Integer b)
        {
            throw new NotImplementedException();
        }

        // должен использовать SUB_ZZ_Z 
        public static Integer operator -(Integer a, Integer b)
        {
            throw new NotImplementedException();
        }

        // должен использовать MUL_ZZ_Z 
        public static Integer operator *(Integer a, Integer b)
        {
            throw new NotImplementedException();
        }

        // должен использовать DIV_ZZ_Z 
        public static Integer operator /(Integer a, Integer b)
        {
            throw new NotImplementedException();
        }

        // должен использовать MOD_ZZ_Z
        public static Integer operator %(Integer a, Integer b)
        {
            throw new NotImplementedException();
        }

        // метод преобразования в строку - для вывода
        public override string ToString()
        {
            string result = "";
            if (!sign)
                result += "-";
            result += number.ToString();
            return result;
        }
    }
}

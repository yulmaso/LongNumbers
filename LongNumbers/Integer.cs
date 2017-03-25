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
        
        public Integer(bool sign, Natural number)
        {
            this.sign = sign;
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

        // Выполнил Плотников А.А.
        // Сложение целых чисел
        public static Integer ADD_ZZ_Z(Integer a, Integer b)
        {
            Natural c = Integer.ABS_Z_N(a);
            Natural d = Integer.ABS_Z_N(b);
            Integer temp = new Integer();

            if (POZ_Z_D(a) == 2 && POZ_Z_D(b) == 2) // если А и В - положительные
            {
                temp = new Integer(c + d); // то ответ = |A| + |B|
            }
            else if (POZ_Z_D(a) == 1 && POZ_Z_D(b) == 1) // если А и В - отрицательные
            {
                temp = new Integer(false, c + d); // то ответ = - (|A| + |B|)
            }
            else if (POZ_Z_D(a) == 2 && POZ_Z_D(b) == 1) // если А - положительное, В - отрицательное
            {
                if (c < d) temp = new Integer(false, d - c); // если |A| < |B| то ответ = - (|B| - |A|) 
                else temp = new Integer(c - d); //  иначе ответ = |A| - |B|
            }
            else if (POZ_Z_D(a) == 1 && POZ_Z_D(b) == 2) // если А - отрицательное, В - положительное
            {
                if (c > d) temp = new Integer(false, c - d); // если |A| > |B| то ответ = - (|A| - |B|)
                else temp = new Integer(d - c); //  иначе ответ = |B| - |A|
            }
            else if (POZ_Z_D(a) == 0) // если A == 0
                temp = new Integer(b.sign, d); // то ответ = В
            else if (POZ_Z_D(b) == 0) // если В == 0
                temp = new Integer(a.sign, c); // то ответ = А

            return temp; // возвращаем ответ     
        }

        // Выполнил Плотников А.А.
        // Вычитание целых чисел
        public static Integer SUB_ZZ_Z(Integer a, Integer b)
        {
            Natural c = Integer.ABS_Z_N(a); // заранее вытаскиваем |A| и |B|
            Natural d = Integer.ABS_Z_N(b);
            Integer temp = new Integer(); // переменная ответа
            if (POZ_Z_D(a) == 2 && POZ_Z_D(b) == 2) // если А и В - положительные
            {
                if (c < d) temp = new Integer(false, d - c); // если |A| < |B| то ответ = - (|B| - |A|) 
                else temp = new Integer(c - d); // иначе ответ = |A| - |B|
            }
            else if (POZ_Z_D(a) == 1 && POZ_Z_D(b) == 1) // если А и В - отрицательные
            {
                if (c > d) temp = new Integer(false, c - d); // если |A| > |B| то ответ = - (|A| - |B|) 
                else temp = new Integer(d - c); // иначе ответ = |B| - |A|
            }
            else if (POZ_Z_D(a) == 2 && POZ_Z_D(b) == 1) // если А - положительное, В - отрицательное
            {
                temp = new Integer(c + d); // то ответ = |A| + |B|
            }
            else if (POZ_Z_D(a) == 1 && POZ_Z_D(b) == 2) // если А - отрицательное, В - положительное
            {
                temp = new Integer(false, c + d); // то ответ = |A| + |B|
            }
            else if (POZ_Z_D(a) == 0) // если A == 0
                temp = new Integer(b.sign, d); // то ответ = В
            else if (POZ_Z_D(b) == 0) // если В == 0
                temp = new Integer(a.sign, c); // то ответ = А

            return temp; // возвращаем ответ
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
            return ADD_ZZ_Z(a, b);
        }

        // должен использовать SUB_ZZ_Z 
        public static Integer operator -(Integer a, Integer b)
        {
            return Integer SUB_ZZ_Z(a, b);
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

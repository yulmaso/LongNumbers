using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMath
{
    class Integer
    {
        private bool sign; // знак числа, true - "+", false - "-"
        private int n;     // номер старшей позиции числа
        private List<ushort> numbers; // массив цифр

        public Integer()
        {
            sign = true;
            n = 0;
            numbers = new List<ushort>();
        }

        //Абсолютная величина числа, результат - натуральное
        public static Natural ABS_Z_N(Integer a)
        {
            throw new NotImplementedException();
        }

        // Определение положительности числа (2 - положительное, 0 — равное нулю, 1 - отрицательное)
        public static int POZ_Z_D(Integer a)
        {
            throw new NotImplementedException();
        }

        // Умножение целого на (-1)
        public Integer MUL_ZM_Z()
        {
            throw new NotImplementedException();
        }

        // Преобразование натурального в целое
        public static Integer TRANS_N_Z(Natural a)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongNumbers
{
    class Polynomial
    {
        private int power;
        private List<Fraction> coefs;

        public Polynomial()
        {
            power = 0;
            coefs = new List<Fraction> { new Fraction() };
        }

        // Сложение многочленов
        public static Polynomial ADD_PP_P(Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        // Вычитание многочленов
        public static Polynomial SUB_PP_P(Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        // Умножение многочлена на рациональное число
        public static Polynomial MUL_PQ_P(Polynomial a, Fraction b)
        {
            throw new NotImplementedException();
        }

        // Умножение многочлена на x^k
        public static Polynomial MUL_Pxk_P(Polynomial a, int k)
        {
            throw new NotImplementedException();
        }

        // Старший коэффициент многочлена
        public Fraction LED_P_Q(Polynomial a)
        {
            throw new NotImplementedException();
        }

        // Степень многочлена
        public Natural DEG_P_N(Polynomial a)
        {
            throw new NotImplementedException();
        }

        // Вынесение из многочлена НОК знаменателей коэффициентов и НОД числителей
        public Fraction FAC_P_Q()
        {
            throw new NotImplementedException();
        }

        // Умножение многочленов
        public static Polynomial MUL_PP_P(Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        //Частное от деления многочлена на многочлен при делении с остатком
        public static Polynomial DIV_PP_P(Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        // Остаток от деления многочлена на многочлен при делении с остатком
        public static Polynomial MOD_PP_P(Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        // НОД многочленов
        public static Polynomial GCF_PP_P(Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        //Производная многочлена
        public Polynomial DER_P_P()
        {
            throw new NotImplementedException();
        }

        // Преобразование многочлена — кратные корни в простые
        public Polynomial NMR_P_P(Polynomial a)
        {
            throw new NotImplementedException();
        }

        // Должен использовать ADD_PP_P
        public static Polynomial operator + (Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        // Должен использовать SUB_PP_P
        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        // Должен использовать MUL_PQ_P
        public static Polynomial operator *(Polynomial a, Fraction b)
        {
            throw new NotImplementedException();
        }

        // Должен использовать MUL_Pxk_P
        public static Polynomial operator *(Polynomial a, int b)
        {
            throw new NotImplementedException();
        }

        // Должен использовать MUL_PP_P
        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        // Должен использовать DIV_PP_P
        public static Polynomial operator /(Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        // Должен использовать MOD_PP_P
        public static Polynomial operator %(Polynomial a, Polynomial b)
        {
            throw new NotImplementedException();
        }

        // метод преобразования в строку - для вывода
        public override string ToString()
        {
            string result = "";
            for (int i = power; i >= 0; i--)
            {
                result += coefs[i].ToString() + " * x^" + i + " + ";
            }
            return result;
        }
    }
}

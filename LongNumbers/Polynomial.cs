using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongNumbers
{
    class Polynomial
    {
        private int power; // степень многочлена
        private List<Fraction> coefs; // массив коэффициентов, 0 индекс - x^0, 1 - x^1 и т.д.

        public Polynomial()
        {
            power = 0;
            coefs = new List<Fraction> { new Fraction() };
        }

        public Polynomial(List<Fraction> coefs)
        {
            this.coefs = coefs;
            power = coefs.Count - 1;
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
        // Выполнил Яковлев
        public static Polynomial MUL_Pxk_P(Polynomial a, int k)
        {
            a.power += k;
            for (int i = 0; i < k; i++)
            {
                a.coefs.Insert(i, new Fraction(0, 1));
            }
            return a;
        }

        // Старший коэффициент многочлена
        // Выполнил Яковлев
        public Fraction LED_P_Q(Polynomial a)
        {
            Fraction MainCoef = coefs[power];
            return MainCoef;
        }

        // Степень многочлена
        // Выполнил Яковлев
        public int DEG_P_N()
        {
            int degree = power;
            return degree;
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
        public void DER_P_P()
        {
            coefs.RemoveAt(0); // вырезаем нейтральный элемент
            power -= 1; // минус степень
            for (int i = 0; i <= power; i++) // умножаем оставшиеся кэфы на степени
            {
                coefs[i] *= i + 1;
            }
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
            for (int i = power - 1; i >= 0; i--)
            {
                result += coefs[i].ToString() + " * x^" + i + " + ";
            }
            return result;
        }
    }
}

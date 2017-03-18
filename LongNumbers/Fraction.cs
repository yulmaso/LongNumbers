using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMath
{
    class Fraction
    {
        private Integer num;
        private Natural denom;

        public Fraction()
        {
            num = new Integer();
            denom = new Natural();
        }

        // Сокращение дроби
        public Fraction REQ_Q_Q()
        {
            throw new NotImplementedException();
        }

        // Проверка на целое, если рациональное число является целым, то «да», иначе «нет»
        public bool INT_Q_B()
        {
            throw new NotImplementedException();
        }

        // Преобразование целого в дробное
        public static Fraction TRANS_Z_Q(Integer a)
        {
            throw new NotImplementedException();
        }

        // Преобразование дробного в целое (если знаменатель равен 1)
        public static Integer TRANS_Q_Z(Fraction a)
        {
            throw new NotImplementedException();
        }

        // Сложение дробей
        public static Fraction ADD_QQ_Q(Fraction a, Fraction b)
        {
            throw new NotImplementedException();
        }

        // Вычитание дробей
        public static Fraction SUB_QQ_Q(Fraction a, Fraction b)
        {
            throw new NotImplementedException();
        }

        // Умножение дробей
        public static Fraction MUL_QQ_Q(Fraction a, Fraction b)
        {
            throw new NotImplementedException();
        }

        // Деление дробей (делитель отличен от нуля)
        public static Fraction DIV_QQ_Q(Fraction a, Fraction b)
        {
            throw new NotImplementedException();
        }

        // Должен использовать ADD_QQ_Q
        public static Fraction operator+ (Fraction a, Fraction b)
        {
            throw new NotImplementedException();
        }

        // Должен использовать SUB_QQ_Q
        public static Fraction operator- (Fraction a, Fraction b)
        {
            throw new NotImplementedException();
        }

        // Должен использовать MUL_QQ_Q
        public static Fraction operator* (Fraction a, Fraction b)
        {
            throw new NotImplementedException();
        }

        // Должен использовать DIV_QQ_Q
        public static Fraction operator/ (Fraction a, Fraction b)
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

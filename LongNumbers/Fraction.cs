﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongNumbers
{
    class Fraction
    {
        private Integer num;
        private Natural denom;

        public Fraction()
        {
            num = new Integer();
            denom = new Natural(1);
        }

        public Fraction(Integer num, Natural denom)
        {
            if (denom.ToString() == "0")
                throw new ArgumentException("Denominator must be non-zero value");
            this.num = num;
            this.denom = denom;
        }

        public Fraction(long num, long denom)
        {
            if (denom == 0)
                throw new ArgumentException("Denominator must be non-zero value");
            this.num = new Integer(num);
            this.denom = new Natural(denom);
        }

        public Fraction(long num)
        {
            this.num = new Integer(num);
            this.denom = new Natural(1);
        }

        // Сокращение дроби
        // Выполнил Медведев
        public Fraction REQ_Q_Q()
        {
            Natural a = Integer.ABS_Z_N(this.num);//числитель
            Natural b = this.denom;//знаменатель
            Natural NOD = Natural.GCF_NN_N(a, b);
            a = a / NOD;
            b = b / NOD;
            bool f;
            if (Integer.POZ_Z_D(this.num) == 1)
                f = true;
            else f = false;
            this.num = new Integer(a);
            if (f)
                this.num.MUL_ZM_Z();

            this.denom = b;
            return this;
        }

        // Проверка на целое, если рациональное число является целым, то «да», иначе «нет»
        // Выполнил Шутемов
        public bool INT_Q_B()
        {
            Integer temp = new Integer(denom);
            Integer nul = new Integer(0);
            if (num % temp == nul)
                return true;
            else
                return false;
        }

        // Преобразование целого в дробное
        // Выполнил Шутемов
        public static Fraction TRANS_Z_Q(Integer a)
        {
            Fraction temp = new Fraction();
            Natural one = new Natural(1);
            temp.num = a;
            temp.denom = one;
            return temp;
        }

        // Преобразование дробного в целое (если знаменатель равен 1)
        public static Integer TRANS_Q_Z(Fraction a)
        {
            Natural nul = new Natural(1);
            Integer nTemp = new Integer(a.num);
            Integer dTemp = new Integer(a.denom);
            if (a.denom == nul && (nTemp / dTemp == a.num))
            {
                Integer temp = new Integer(a.num);
                return temp;
            }
            else
                throw new ArgumentException("You can not convert to an integer, the denominator is not 1");

        }

        // Сложение дробей
        // Выполнил Медведев
        public static Fraction ADD_QQ_Q(Fraction a, Fraction b)
        {
            Natural NOK = Natural.LCM_NN_N(a.denom, b.denom);
            Integer x = new Integer(NOK / a.denom);//коэфициент для 1 дроби
            Integer y = new Integer(NOK / b.denom);//для второй
            Fraction temp = new Fraction(0);
            temp.num = a.num * x + b.num * y;
            temp.denom = NOK;
            return temp;
        }

        // Вычитание дробей
        // Выполнил Медведев
        public static Fraction SUB_QQ_Q(Fraction a, Fraction b)
        {
            Natural NOK = Natural.LCM_NN_N(a.denom, b.denom);
            Integer x = new Integer(NOK / a.denom);//коэфициент для 1 дроби
            Integer y = new Integer(NOK / b.denom);//для второй
            Fraction temp = new Fraction(0);
            temp.num = a.num * x - b.num * y;
            temp.denom = NOK;
            return temp;
        }

        // Выполнил Плотников А.А.
        // Умножение дробей
        public static Fraction MUL_QQ_Q(Fraction a, Fraction b)
        {
            Integer ca = new Integer(a.num); // вытаскиваем из дробей числители и знаменатели
            Integer cb = new Integer(b.num);
            Natural da = new Natural(a.denom);
            Natural db = new Natural(a.denom);
            Fraction temp = new Fraction(ca * cb, da * db); // перемножаем их соответственно
            return temp; // возвращаем ответ  
        }

        // Выполнил Плотников А.А.
        // Деление дробей (делитель отличен от нуля)
        public static Fraction DIV_QQ_Q(Fraction a, Fraction b)
        {
            if (b.num == new Integer())
                throw new ArgumentException();
            Natural ca = new Natural(Integer.ABS_Z_N(a.num)); // вытаскиваем из дробей числители и знаменатели
            Natural cb = new Natural(Integer.ABS_Z_N(b.num));
            Natural da = new Natural(a.denom);
            Natural db = new Natural(b.denom);
            bool sign = true; // знак ответа
            if ((Integer.POZ_Z_D(a.num) == 1 && Integer.POZ_Z_D(b.num) == 2) || (Integer.POZ_Z_D(a.num) == 2 && Integer.POZ_Z_D(b.num) == 1))
                sign = false; // если знаки исходных дробей различны, то меняем знак ответа на минус
            Integer num = new Integer(sign, ca * db); //вычисляем числитель
            Fraction temp = new Fraction(num, cb * da); // вычисляем знаменатель
            return temp; // возвращаем ответ
        }

        // Должен использовать ADD_QQ_Q
        public static Fraction operator+ (Fraction a, Fraction b)
        {
            return ADD_QQ_Q(a, b);
        }

        // Должен использовать SUB_QQ_Q
        public static Fraction operator- (Fraction a, Fraction b)
        {
            return SUB_QQ_Q(a, b);
        }

        // Должен использовать MUL_QQ_Q
        public static Fraction operator* (Fraction a, Fraction b)
        {
            return MUL_QQ_Q(a, b);
        }

        public static Fraction operator* (Fraction a, int b)
        {
            return a * new Fraction(b);
        }

        // Должен использовать DIV_QQ_Q
        public static Fraction operator/ (Fraction a, Fraction b)
        {
            return DIV_QQ_Q(a, b);
        }

        // метод преобразования в строку - для вывода
        public override string ToString()
        {
            if (denom.ToString() != "1")
                return num.ToString() + " / " + denom.ToString();
            else
                return num.ToString();
        }
    }
}

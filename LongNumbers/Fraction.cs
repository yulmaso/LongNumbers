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
        public Fraction REQ_Q_Q()
        {
            throw new NotImplementedException();
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
            return MUL_QQ_Q(a, b);
        }

        public static Fraction operator* (Fraction a, int b)
        {
            return a * new Fraction(b);
        }

        // Должен использовать DIV_QQ_Q
        public static Fraction operator/ (Fraction a, Fraction b)
        {
            return Fraction DIV_QQ_Q(a, b);
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

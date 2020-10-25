using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Rational
    {
        int _P;
        int _Q;

        public Rational(int P, int Q)
        {

            if (Q <= 0)
            {
                _P = 0;
                _Q = 1;
            }
            else
            {
                _P = P;
                _Q = Q;
            }
        }

        public bool GreaterThen(Rational rational)
        {
            return rational._P * this._Q < rational._Q * this._P;
        }

        public   bool Equals(Rational rational)
        {
            return rational._P * this._Q == rational._Q * this._P;
        }

        static public Rational operator +(Rational rational1, Rational rational2)
        {
            Rational sum = new Rational(rational1._P * rational2._Q 
                + rational1._Q * rational2._P, rational1._Q * rational2._Q);
            return sum;


        }

        static public Rational operator -(Rational rational1, Rational rational2)
        {
            Rational sum = new Rational(rational1._P * rational2._Q
                - rational1._Q * rational2._P, rational1._Q * rational2._Q);
            return sum;


        }

        static public Rational operator *(Rational rational1, Rational rational2)
        {
            Rational sum = new Rational(rational1._P * rational2._P
                , rational1._Q * rational2._Q);
            return sum;


        }

        public int getNumerator()
        {
            return _P;
        }

        public int getDenominator()
        {
            return _Q;
        }

        public override string ToString()
        {
            return $"{_P} / {_Q}";
        }
    }
}

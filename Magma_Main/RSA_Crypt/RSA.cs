using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace RSA_Crypt
{
    class RSA
    {
        BigInteger e, n, _f_n, d;

        public RSA() { }

        public RSA(BigInteger p, BigInteger q)
        {
            if (!IsPrime(p))
                throw new Exception("P должно быть простым числом");
            if (!IsPrime(q))
                throw new Exception("Q должно быть простым числом");

            n = p * q;
            _f_n = Eiler(p, q);
            Refresh_E();
        }

        public void Set_p_q(BigInteger p, BigInteger q)
        {
            if (!IsPrime(p))
                throw new Exception("P должно быть простым числом");
            if (!IsPrime(q))
                throw new Exception("Q должно быть простым числом");

           n = p * q;
            _f_n = Eiler(p, q);
           Refresh_E();
        }

        public BigInteger Encrypt(BigInteger msg)
        {
            return Power(msg, e) % n;
        }

        public BigInteger Decrypt(BigInteger msg)
        {
            return Power(msg, d) % n;
        }

        public static bool IsPrime(BigInteger value)
        {
            if (value % 2 == 0)
                return false;
            for (BigInteger i = 3;  i * i <= value; i += 2)
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }
        public static BigInteger Power(BigInteger value, BigInteger pow)
        {
            BigInteger tmp = value;
            if(pow == 0)
            {
                return 1;
            }
            for (BigInteger i = 0; i < pow - 1; i++)
            {
                tmp *= value;
            }
            return tmp;
        }

        /// <summary>
        /// Вычисление закрытой экспоненты D, через расширенный алгоритм Евклида
        /// </summary>
        /// <param name="f_n">функция Эйлера от n</param>
        /// <param name="e">открытая экспонента</param>
        /// <returns></returns>
        private BigInteger Get_D(BigInteger f_n, BigInteger e)
        {
            BigInteger res = Extended_Euclid(f_n, e)[2];
            if (res < 0)
                res = f_n + res;
            return res;
        }

        public static BigInteger Eiler(BigInteger p, BigInteger q)
        {
            return (p - 1) * (q - 1);
        }

        public static BigInteger Euclid(BigInteger a, BigInteger b)
        {
            while(a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            return a + b;
        }
        /// <summary>
        /// Расширенный алгоритм Евклида
        /// </summary>
        /// <returns>   
        /// res[0] - d
        /// res[1] - x
        /// res[2] - y
        /// a * x + b * y = d
        /// </returns>
        public static BigInteger[] Extended_Euclid(BigInteger a, BigInteger b)            
        {
            BigInteger q, r, x1, x2, y1, y2;
            BigInteger[] res = new BigInteger[3];

            if (b == 0)
            {
                res[0] = a;
                res[1] = 1;
                res[2] = 0;   
                return res;
            }

            x2 = 1; x1 = 0; y2 = 0; y1 = 1;
            
            while (b > 0)
            {
                q = a / b;
                r = a - q * b;

                res[1] = x2 - q * x1;
                res[2] = y2 - q * y1;

                a = b;
                b = r;

                x2 = x1; x1 = res[1];
                y2 = y1; y1 = res[2];
            }

            res[0] = a; res[1] = x2; res[2] = y2;
            return res;
        }


        public void Refresh_E()
        {
            bool IsCorrect = false;
            Random R = new Random();
            while (!IsCorrect)
            {
                e = R.Next(2, (int)_f_n - 1);
                if(Euclid(e, _f_n) == 1)
                {
                    IsCorrect = true;
                }
            }
            d = Get_D(_f_n, e);
        }

        public BigInteger E
        {
            get { return e; }
            set
            {
                if(Euclid(value, _f_n) != 1)
                {
                    throw new Exception("e не взаимопростое с " + _f_n.ToString());
                }
                else if (value >= _f_n)
                {
                    throw new Exception("e больше или равно " + _f_n.ToString());
                }
                else if (value <= 1)
                {
                    throw new Exception("e меньше или равно 1");
                }
                else
                {
                    e = value;
                    d = Get_D(_f_n, e);
                }
            }
        }
        public BigInteger D
        {
            get { return d; }
        }
        public BigInteger N
        {
            get { return n; }
        }
    }
}

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

        public RSA(BigInteger p, BigInteger q)
        {
            this.n = p * q;
            _f_n = Eiler(p, q);
        }

        public void Set_p_q(BigInteger p, BigInteger q)
        {
            this.n = p * q;
            _f_n = Eiler(p, q);
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
            for (BigInteger i = 0; i < pow; i++)
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
            return Extended_Euclid(e, f_n)[1];
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

    }
}

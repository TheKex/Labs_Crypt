using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magma_Main
{
    class Magma_Crypt
    {
        private UInt32[] Key = new UInt32[8]; //256 бит
        private uint[] iter_keys = new uint[32]; //32 итерационных ключа


        static private byte[,] Pi =
        {
            { 12, 4, 6, 2, 10, 5, 11, 9, 14, 8, 13, 7, 0, 3, 15, 1 },
            { 6, 8, 2, 3, 9, 10, 5, 12, 1, 14, 4, 7, 11, 13, 0, 15 },
            { 11, 3, 5, 8, 2, 15, 10, 13, 14, 1, 7, 4, 12, 9, 6, 0 },
            { 12, 8, 2, 1, 13, 4, 15, 6, 7, 0, 10, 5, 3, 14, 9, 11 },
            { 7, 15, 5, 10, 8, 1, 6, 13, 0, 9, 3, 14, 11, 4, 2, 12 },
            { 5, 13, 15, 6, 9, 2, 12, 10, 11, 7, 8, 1, 4, 3, 14, 0 },
            { 8, 14, 2, 5, 6, 9, 1, 12, 15, 4, 11, 0, 13, 10, 3, 7 },
            { 1, 7, 14, 13, 0, 5, 8, 3, 4, 15, 10, 6, 9, 12, 11, 2 }
        };

        public void Set_key(UInt32[] key)
        {
            Key = key;
            Refresh_Iter_Keys();
        }

        private void Refresh_Iter_Keys()
        {
            uint[] tmp = new uint[8];
            for (int i = 0; i < 8; i++)
            {
                iter_keys[i] = Key[i];
                iter_keys[i + 8] = Key[i];
                iter_keys[i + 16] = Key[i];
                iter_keys[i + 24] = Key[7 - i];
            }
        }
        
        public uint[] Iter_Keys
        {
            get { return iter_keys; }
        }


        public UInt32[] Crypt(UInt32[] Msg)
        {
            uint[] Res = new uint[2];
            Res = Msg;
            for (int i = 0; i < 32; i++)
            {
                Res = Magma_G(iter_keys[i], Res[1], Res[0]);
            }
            return Res;
        }

        public UInt32[] Decrypt(UInt32[] Msg)
        {
            uint[] Res = new uint[2];
            Res = Msg;
            for (int i = 31; i >= 0; i--)
            {
                Res = Magma_G(iter_keys[i], Res[1], Res[0]);
            }
            return Res;
        }

        private static uint Magma_T(uint a)
        {
            uint res = 0;
            for (int i = 0; i < 8; i++)
            {
                uint tmp = (uint)(( a & ( 0xf << (i * 4))) >> (i * 4));
                res ^= (uint)Pi[i , tmp] << (i * 4) ;
            }
            return res;
        }

        public static uint cicle_move_left(byte n, uint a)
        {
            bool tmp = false;
            uint tmp_s = (uint)0x1 << 31;
            for (int i = 0; i < n; i++)
            {
                tmp = (a & tmp_s) == tmp_s;
                a = (uint)((a << 1) + (tmp ? 1 : 0));
            }
            return a;
        }

        public static uint Magma_g(uint k, uint a)
        {
            uint tmp = a + k;
            tmp = Magma_T(tmp);
            return cicle_move_left(11, tmp);
        }

        public static uint[] Magma_G(uint k, uint a1, uint a0)
        {
            uint[] res = new uint[2];
            res[1] = a0;
            res[0] = Magma_g(k, a0) ^ a1;
            return res;
        }

        

        
    }
}

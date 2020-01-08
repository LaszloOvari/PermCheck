using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 14, 11, 13, 12 };
            Console.WriteLine(Solution(A));
        }

        public static int Solution(int[] A)
        {
            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > A.Length) return 0;
                if (++B[A[i] - 1] > 1) return 0;
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 0) return 0;
            }
            return 1;
        }
    }
}

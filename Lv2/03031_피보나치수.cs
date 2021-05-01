using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv2
{
    class _03031_피보나치수
    {
        static void Main_03031(string[] args)
        {
            Console.WriteLine("hello world");

            Solution sol = new Solution();
            Console.WriteLine(sol.solution(50)); 
        }


        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;

                int[] F = new int[n + 1];
                F[0] = 0;
                F[1] = 1;

                for(int i = 2; i < n + 1; i++)
                {
                    F[i] = (F[i - 1] % 1234567) + (F[i - 2] % 1234567);
                }

                answer = F[n] % 1234567;

                return answer;
            }
        }

       
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * n개의 수의 최소 공배수 구하라
 * arr은 길이 1~15
 * arr원소는 100이하 자연수
 * 6 이랑 9 는 18 = 2 * 3 * 3
 * 2 * 3 / 3 * 3
 * 즉, 두 개의 최소 공약수를 n - 1 만큼 나눠주면 된다? 
 */

namespace Lv2
{
    class _03021_N개의최소공배수
    {
        static void Main_03021(string[] args)
        {
            Solution sol = new Solution();
            int[] arr = { 2, 6, 8, 14 };
            // 2 / 2 * 3 / 2 * 2 * 2 / 2 * 7
            // 2 * 3 * 2 * 2 * 7
            // 2^3 * 3 * 7 소인수 분해를 하고, 각 인수의 갯수의 곱이 최소 공배수 인데...
            // 두개 씩 비교하고, 공약수를 나누고 곱하면 최소 공배수가 된다..
       
            
            Console.WriteLine(sol.solution(arr));
        }

        public class Solution
        {
            public int solution(int[] arr)
            {
                int answer = 0;

                //배열을 두 개 씩 비교하면서 공배수를 찾아내는 형태로? 비효율 적이긴 한데..
                int size = arr.Length;

                for(int i = 1; i < size; i++)
                {
                    //arr[i - 1] 과 arr[i] 비교 
                    int front = arr[i - 1];
                    if (arr[i - 1] < arr[i]) front = arr[i];

                }

                return answer;
            }
        }
    }

    
}

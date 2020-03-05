using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 수평 직선 탑 N대 세움, 꼭대기에 신호 수신기
 * 수신기는 보낸 탑보다 높은 탑에서만 수신(같은 높이도 수신 안함)
 * 한번 수신된 신호는 다른 탑으로 송신 안됨
 * 탑의 높이 담은 배열 heights
 * 각 탑이 쏜 신호를 받은 탑을 기록한 배열 리턴
 * heights 길이 2~100
 * 탑 높이 1~100
 * 수신탑 없으면 0 표시
 */

namespace Lv2
{
    class _03041_탑
    {
        static void Main_03041(string[] args)
        {

            int[] heights = new int[] { 6, 9, 5, 7, 4 };
            for (int i = 0; i < heights.Length; i++) Console.WriteLine(heights[i]);
            Console.WriteLine("test");

            for (int i = 0; i < heights.Length; i++) Console.WriteLine(Solution.solution(heights)[i]);
        }
    }

    public class Solution
    {
         public static int[] solution(int[] heights)
        {
            int[] answer = new int[] { };

            int size = heights.Length;
            Array.Resize(ref answer, size);

            for(int i = size - 1; i >= 0; i--)
            {
                for(int j = i - 1; j >= 0; j--)
                {
                    if(heights[i] < heights[j])
                    {
                        answer[i] = j + 1;
                        break;
                    }
                    if(j == 0)
                    {
                        answer[i] = 0;
                        break;
                    }
                }
            }
            

            return answer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 기능 100% 일 때 작동
 * 각 기능 개발은 독립적
 * 뒤 기능은 앞 기능 배포 시 배포
 * progresses 작업 진도 / speeds 개발 속도
 * 각 배포마다 몇 기능이 배포되는지 리턴
 * - 배열 길이는 100개 이하
 * - 프로그래스와 100 미만, 스피드는 100 이하 자연수
 * - 배포는 하루 한번, 하루 개발 끝에 배포
 */

namespace Lv2
{
    class _03091_기능개발
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("테스트");

            int[] a = { 40, 93, 30, 55, 60, 65 };
            int[] b = { 60, 1, 30, 5, 10, 7 };

            Console.WriteLine(Solution.solution(a, b).Length);
        }



        public class Solution
        {
            public static int[] solution(int[] progresses, int[] speeds)
            {
                

                int size = progresses.Length;
                int[] doneDay = new int[size];
                int day = 0;

                //제작 돌리기
                while(true)
                {
                    first:
                    day++;
                    //작업하기
                    for(int i = 0; i < size; i++)
                    {
                        if (progresses[i] >= 100) continue;
                        progresses[i] += speeds[i];
                        if (progresses[i] >= 100) doneDay[i] = day;
                    }

                    //올 배포 확인하기
                    for (int i = 0; i < size; i++)
                    {
                        if (doneDay[i] == 0) goto first;
                    }
                    break;
                }

                int[] temp = new int[size];

                for(int i = 0; i < size; i++)
                {
                    int lounch = 0;
                    for(int j = i + 1; j < size; j++)
                    {
                        if (doneDay[j] > doneDay[i])
                        {
                            lounch++;
                            break;
                        }
                        if (doneDay[i] > doneDay[j] && doneDay[j] != 0)
                        {
                            lounch++;//같이 배포
                            doneDay[j] = 0;
                        }
                    }
                    temp[i] = lounch;
                }

                int answerSize = 0;

                for(int i = 0; i < size; i++)
                {
                    if (temp[i] != 0) answerSize++;
                }

                int[] answer = new int[answerSize];

                for (int i = 0; i < size; i++)
                {
                    if (temp[i] != 0)
                    {
                        for(int j = 0; j < answerSize; j++)
                        {
                            if (answer[j] != 0) continue;
                            answer[j] = temp[i];
                        }
                    }
                }

                return answer;
            }
        }

    }


    
}

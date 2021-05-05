using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv2
{
    class _0505_타겟넘버
    {
        
        //Console.WriteLine("테스트");
        public static void test()
        {
            Console.WriteLine("솔루션 시작\n입력값 확인\n"); 

            int[] array = new int[5] { 1, 1, 1, 1, 1 };
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.Write("\n\n");


            solution(array, 3);

            /*  n개의 음이 아닌 정수의 배열. 더하고 빼서 타겟 넘버 만들기
             *  [ 제한사항 ]
             *   - 배열 개수 : 2~20
             *   - 1~50의 자연수
             *   - 타겟 넘버 : 1~1000
             */
            int solution(int[] numbers, int target)
            {
                int answer = 0;
                int length = numbers.Length;

                // 1.-가 몇개 필요한지 체크
                for (int j = 0; j < length; j++)
                {
                    for (int i = 0; i < length; i++)
                    {
                        //다 더해봐
                        answer += numbers[i];
                    }
                    if (answer == target) break; //다 더했는데 타겟에 맞으면 나가기
                    else
                    {
                        //타겟에 안맞으면 - 처리 하기
                        answer = 0;
                        numbers[j] *= -1;
                    }

                }

                Console.WriteLine(answer);
                

                // 2.-가 붙을 수 있는 조합 수 산출




                return answer;
            }
        }

        
    }
}

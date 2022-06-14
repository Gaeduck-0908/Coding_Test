using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCD
{
    class Program
    {
        static void Main(string[] args)
        {
            //케이스 입력
            int a = int.Parse(Console.ReadLine());

            //케이스 수만큼 반복
            for (int i = 0; i < a; i++)
            {
                // 학생과 점수 입력
                string[] input = Console.ReadLine().Split(' ');
                // 첫번째 수가 학생이므로 인덱스 0번을 변수로 담음
                int studentNum = int.Parse(input[0]);
                // 점수를 담음
                int[] inputNum = new int[studentNum + 1];
                //더한값
                float sum = 0;
                //평균
                float average = 0;

                //학생의 수만큼 반복
                for (int j = 0; j < studentNum + 1; j++)
                {
                    //점수를 담아줌
                    inputNum[j] = int.Parse(input[j]);
                    //점수가 담아져있는 인덱스부터
                    if (j >= 1)
                    {
                        sum += inputNum[j];
                    }
                }

                // 평균을 만듬
                average = sum / (float)studentNum;

                //평균을 넘은 학생을 셀 변수
                float count = 0;

                // 학생의 수만큼 반복
                for (int j = 0; j < studentNum + 1; j++)
                {
                    // 평균보다 높은 학생을 셈
                    if (j >= 1 && inputNum[j] > average)
                    {
                        count++;
                    }
                }

                //평균 학생의 비율을 구함
                float result = count / (float)studentNum;

                //포매팅 사용해서 출력
                Console.WriteLine("{0:#0.000%}", result);
            }
        }
    }
}
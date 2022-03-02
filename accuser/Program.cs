using System;

namespace _22_kakao_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //신고당한 사람
            string[] id_list = { "muzi", "frodo", "apeach", "neo" };
            //신고당한 횟수
            string[] report = { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
            //신고당하면 이용정지되는 기준값
            int k = 2;  
            */
            string[] id_list = { "con", "ryan" };
            string[] report = { "ryan con", "ryan con", "ryan con", "ryan con" };
            int k = 3;
  
            foreach (string id in id_list)
            {
                Console.WriteLine(id);
            }
            Console.WriteLine("Hello World!");

            Solution sol = new Solution();
            sol.solution(id_list, report, k);
        }
    }
}

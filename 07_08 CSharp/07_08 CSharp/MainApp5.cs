//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//// 읽기 전용  필드 

//namespace _07_08_CSharp
//{
//    internal class MainApp5
//    {
//        class Configuration
//        {
//            // readonly 키워드를 이용해서 읽기전용 필드를 
//            // 선언 한다.
//            private readonly int min; // 읽기전용 변수
//            private readonly int max; 
//            public Configuration(int v1, int v2)
//            {
//                min = v1;//읽기전용 필드는 생성자 안에서만 초기화 가능
//                max = v2; // 생성자에서만 초기화해야함
//            }
//            public void ChangeMax(int newMax)
//            {
//                //max = newMax; // 생성자가 아닌 다른 곳에서 값을 수정 하러
//                ////하면 컴파일 에러가 난다.
//            }
            
//        }
//        static void Main(string[] args)
//        {
//            Configuration c = new Configuration(100, 100);
           
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//// 분할 클래스
//// 같은 클래스를 여러번 나눠 구현 하는 클래스를 말한다.
//namespace _07_08_CSharp
//{
//    partial class MyClass
//    {
//        public void Method1()
//        {
//            Console.WriteLine("Method1()");
//        }
//        public void Method2()
//        {
//            Console.WriteLine("Method2()");
//        }
//    }

//    partial class MyClass //  partial 많은 클래스를 한번에 분리 할 수 있는 클래스
//    {
//        public void Method3()
//        {
//            Console.WriteLine("Method3()");
//        }
//        public void Method4()
//        {
//            Console.WriteLine("Method4()");
//        }
//    }
   
//    internal class MainAPP9
//    {
//        static void Main(string[] args)
//        {
//            MyClass obj = new MyClass();
//            obj.Method1();
//            obj.Method2();
//            obj.Method3();
//            obj.Method4();
//        }
//    }
//}

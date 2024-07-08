//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _07_08_CSharp
//{
//    // 부모에선 virtual 
//    // 자식에선 override 
//    // initizlize 초기화
//   class armotSuite
//    {
//        public virtual void Initizlize()
//        {
//            // 자식에게 오버라이딩(물려줄) 대상 메서드
//            Console.WriteLine("Armored");
//        }
//    }
//    class IronMAn : armotSuite
//    {
//        // 위에 armotSuite에서 부모클래스에서 물려 물려받았지만
//        // 재정의 해서 다르게 사용 할 것이라고 선언 하는 것
//        // override 없으면 그대로 물려받는 것이다.
        
//        public override void Initizlize()
//        {
//            base.Initizlize(); // 부모클래스의 함수를 물려받았지만
//            Console.WriteLine("Repulsor Ray Armed"); // 기능을 추가 할 것이다.
            
//        }
//    }

//    class WarMarchine : armotSuite
//    {
//        public override void Initizlize()
//        {
//            base.Initizlize(); // 똑같이 부모클래스 함수를 물려받았고
//            Console.WriteLine("Double -Barrel Cannon Armed");  
//            Console.WriteLine("Micro -Rocket Launcher Armed"); // 기능을 추가함
//        }
//    }
//    internal class MainApp3
//    {
//        class Armop;
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Creating AnmorSuite");
//            armotSuite suite = new armotSuite();
//            suite.Initizlize();
//            Console.WriteLine("\n Create IronMan..");
//            armotSuite ironman = new IronMAn();
//            ironman.Initizlize();
//            Console.WriteLine("\n Create warmachine..");
//            armotSuite warmachine = new WarMarchine();
//            warmachine.Initizlize();
//        }
//    }
    
//}

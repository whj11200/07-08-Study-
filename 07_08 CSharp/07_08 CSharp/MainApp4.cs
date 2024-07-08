//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////메소드 숨기기
//// 메소드 숨기기란?
//// 부모클래스에서 구현된 버전의 메소드를 감추고
//// 자식 클래스에서 구현 된 버전만 보여 주는 것
//// 부모 클래스에 있는 메서드는 숨기고  자식에서 오버라이드 한 메서드만 보여주는 것
//namespace _07_08_CSharp
//{
//    class Base // 부모
//    {
//        public void MyMethod()
//        {
//            Console.WriteLine("Base.MyMethod()");
//        }


//    }
//    class Derived : Base
//    {
//        public new void MyMethod() //  new를 쓰면 새로 작성해서 부모에게 물려받은  메서드는 안보이게함
//        {
//            Console.WriteLine("Derived.MyMeted()");
//        }
//    }

//    internal class MainApp4
//    {
//        static void Main(string[] args)
//        {
//            Base bassObj = new Base();
//            bassObj.MyMethod();
//            Derived derived = new Derived();
//            derived.MyMethod();

//            Base BassOrDerived = new Derived();
//            BassOrDerived.MyMethod(); //  이새키 다행성 런타임 이여서 참고를 가려져야하는데 안됌 ㅋㅋㅋㅋ
//        }
//    }
//}

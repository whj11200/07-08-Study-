//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _07_08_CSharp
//{

//    internal class Mainapp2
//    {
//        //is : 객체가 해당 형식을 검사하여 그 결과물 bool 값으로 변환
//        //as : 형식변환자가 같은 역할을 한다. 다만 형식변환자가 변환에 실패 하는 경우
//        // 예외를 던지는 반면 as 연산자는 객체 참조를 null로 만든다는 것이 다름
//        static void Main(string[] args)
//        {
//            Mammal mammal = new Dog();
//            Dog dog;
//            if(mammal is Dog)
//            {
//                dog = (Dog)mammal;
//                dog.Bark();
//            }
//            Mammal mammal2 = new Cat();
//            Cat cat =  mammal2 as Cat;
//            if(cat != null)
//            {
//                cat.Meow();
               
//            }
//            else
//            {
//                Console.WriteLine("Cat2 is not a cat");
//            }



//        }
//        //기반 클래스(부모)와 파생클래스(자식) 사이의 형식 변화
//        // is as
//        class Mammal //포유류
//        {
//            public void Nurse()
//            {
//                Console.WriteLine("Nurse()");
//            }
//        }
//        class Dog : Mammal
//        {
//            public void Bark()
//            {
//                Console.WriteLine("Bark()");
//            }
//        }
//        class Cat : Mammal
//        {
//            public void Meow()
//            {
//                Console.WriteLine("Meow()");
//            }
//        }
       
//    }
//}

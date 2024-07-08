using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 확장 메서드  Extension Method
// 기존 클래스에 기능을 확장 하는 기법
// 부모클래스를 물려받아 자식 클래스를 만든 뒤 여기에 
// 기능을 추가하는 상속과는 다르다.
namespace _07_08_CSharp
{
    public static class IntergerExtension //  static 으로 설정하여 정적으로 클래스로 변경함
    {
        public static int Square(this int myint) 
        {
            return myint * myint;
        }
        public static int Power(this int Myint, int exponment)
        {
            int result = Myint;
            for (int i = 1; i < exponment; i++)
            {
                result = result * Myint;
            }
            return result;
        }
        public static int diretion(this int myint)
        {
            return myint / myint;
        }
    }
    internal class MainApp10
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");
            Console.WriteLine($"2/2 :{2.diretion()}");
        }
    }
}
// 클래스와 구조체의 차이


//                              클래스            구조체


// 키워드                       class             struct
// 형식                       참조형식(heep)      값형식
// 복사                        앏은 복사         깊은 복사
// 인스턴스 생성        new 연산자 생성자 필요  선언만으로 생성
// 생성자        매개변수 없는 생성자 선언가능   매개변수없는 생성자 선언 불가능
// 상속                     가능               값형식이므로 상속 불가능
//                     목적: 실제 세계의 객체를 추상화      목적: 데이터를 담기 위한 목적의 자료 구조로 쓰이기 위해
//                       하려는데 존재의 이유 이지만 
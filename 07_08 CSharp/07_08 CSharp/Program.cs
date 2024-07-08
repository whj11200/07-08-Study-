//namespace _07_08_CSharp
//{
//    // sealed 클래스 키워드 앞에다 선언 상속 봉인이 된다.
//    class Base
//    {

//        protected string Name;
//        protected int PhonNumnber;
//        public Base()
//        {
//            Name = string.Empty;
//        }
//        public Base(string Name) // 부모
//        {
//            Console.WriteLine("Base()");

//            this.Name = Name;
//        }
//        public Base(string Name, int PhonNumber): this (Name)
//        {
//            this.Name = Name;
//            this.PhonNumnber = PhonNumber;
//        }
//        ~Base()
//        {
//            Console.WriteLine("~Base()");
//        }
//        public void SetPrint()
//        {
//            Console.WriteLine($"이름{Name}: 전화번호 :{PhonNumnber}");
//        }

//    }
//    class Derived : Base // Derived 클래스는 Base 클래스는 상속했다.
//    {
//        public Derived(string Name) :base(Name)
//        {
//            Console.WriteLine("Derived");

//        }
//        public Derived(string Name, int PhonNumber)
//        : base(Name, PhonNumber)
//            //자식클래스는 반드시 부모클래스 생성자를 호출하여서 초기화해야한다.
//        {

//        }
//        ~Derived()
//        {
//            Console.WriteLine("~Deriveds");
//        }
//        public Derived()
//        {
//            Console.WriteLine("Derived 매개변수 없는 생성자(string Name),int PhonNumber");
//        }
//    }
//    internal class Program
//    {

//        static void Main(string[] args)
//        {
//            Derived derived = new Derived("홍길동",12234);
//            derived.SetPrint();
//            Derived derived1 = new Derived("하하하");
//            Derived derived2 = new Derived();

//        }
//    }
//}

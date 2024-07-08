//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _07_08_CSharp
//{
//    internal class sibal
//    {
//        class Hero
//        {
//            protected int hp;
//            protected int attack;
//            protected string name;
//            public Hero() { }
//            public Hero(string name)
//            {
//                this.name = name;
//            }
//        }
//        class Knight : Hero
//        {
//            public Knight(int attack, string name) : base(name)
//            {
//                this.attack = attack;
//                this.hp = 100;
//            }
//            public int Attack
//            {
//                get { return attack; }
//            }
//            public string Name
//            {
//                get { return name; }
//            }
//        }
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Knight knight = new Knight(200, "james");
//                Console.WriteLine($"{knight.Name}의 공격력은 {knight.Attack}입니다.");
//            }
//        }
//    }
//}

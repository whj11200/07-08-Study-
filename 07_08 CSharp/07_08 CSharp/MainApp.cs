//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////    
//// 클래스 안에 클래스가 들어 있는 것을 중첩 클래스라 한다.
//// 클래스를 쓰는 이유
//// 1. 클래스 외부에 공개하고 싶지 않은 형식을 만들때
//// 2. 현재 클래스의 일부분 처럼  표현 할 수 있는 클래스를 만들고자 할때
//namespace _07_08_CSharp
//{

//    internal class MainApp7
//    {
//        class Configuration
//        {
//            List<ItemValue> itemConfig = new List<ItemValue>();// List == 어떤 자료형이든 다 담을 수 있는 클래스 
//            public void SetConfig(string item, string Vaulse)
//            {
//                ItemValue iv = new ItemValue();
//                iv.SetVelue(this,item, Vaulse);
//            }
//            public string GetConfig(string item,string Vaulse,string)
//            {
//                foreach (ItemValue itemValue in itemConfig)
//                {
//                    if (iv.GetItem() == item)
//                        return;
//                }
//            }
//            private class ItemValue
//            {
//                private string item;
//                private string value;
//                public void SetVelue(Configuration config, string item, string value)
//                {
//                    this.item = item;
//                    this.value = value;
//                    bool found = false;
//                    for (int i = 0; i < config.listConfig.Count; i++)
//                    {
//                        if (config.listConfig[i].item == item)
//                        {
//                            config.listConfig[i] = this;
//                            found = true;
//                            break;
//                        }
//                    }
//                    if (found == this)
//                    {
//                        config.listconfig.Add(this);    
//                    }
                    
//                }
//                public string GetItem()
//                {
//                    return item;
//                }
//                public string GetValue()
//                {
//                    return value;
//                }

//            }


//        }
//        // 이런식으로 외부적으로 안보이게 할 수 있는 클래스 생성

//        static void Main(string[] args)
//        {
//            Configuration config = new Configuration();
//            config.SetConfig("Version", "V 5.0");
//            config.SetConfig("Size", "655,324 k8");
//            Console.WriteLine(config.GetConfig("Version"));
//            Console.WriteLine(config.GetConfig("Size"));

//            config.SetConfig("Version", "V 5.0.1");
//            Console.WriteLine(config.GetConfig("Version"));
//        }
//    }
//}
//using System;
//using System.Collections.Generic;

//namespace _07_08_CSharp
//{
//    internal class MainApp7
//    {
//        class Configuration
//        {
//            List<ItemValue> itemConfig = new List<ItemValue>();

//            public void SetConfig(string item, string value)
//            {
//                ItemValue iv = new ItemValue();
//                iv.SetValue(this, item, value);
//            }

//            public string GetConfig(string item)
//            {
//                foreach (ItemValue itemValue in itemConfig)
//                {
//                    if (itemValue.GetItem() == item)
//                        return itemValue.GetValue();
//                }
//                return null;
//            }

//            private class ItemValue
//            {
//                private string item;
//                private string value;

//                public void SetValue(Configuration config, string item, string value)
//                {
//                    this.item = item;
//                    this.value = value;
//                    bool found = false;
//                    for (int i = 0; i < config.itemConfig.Count; i++)
//                    {
//                        if (config.itemConfig[i].item == item)
//                        {
//                            config.itemConfig[i] = this;
//                            found = true;
//                            break;
//                        }
//                    }
//                    if (!found)
//                    {
//                        config.itemConfig.Add(this);
//                    }
//                }

//                public string GetItem()
//                {
//                    return item;
//                }

//                public string GetValue()
//                {
//                    return value;
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            Configuration config = new Configuration();
//            config.SetConfig("Version", "V 5.0");
//            config.SetConfig("Size", "655,324 KB");
//            Console.WriteLine(config.GetConfig("Version"));
//            Console.WriteLine(config.GetConfig("Size"));

//            config.SetConfig("Version", "V 5.0.1");
//            Console.WriteLine(config.GetConfig("Version"));
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    //定义委托，它定义了可以代表的方法的类型
    public delegate void GreetingDelegate(string name);
    //新建的GreetingManager类
    public class GreetingManager
    {
        public GreetingDelegate delegate1;
        //这一次我们在这里声明一个事件
        public event GreetingDelegate MakeGreet;
        public void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }
        //public void GreetPeople(string name)
        //{
        //    //if(delegate1 != null) delegate1(name);
        //    delegate1?.Invoke(name);//这个是简化版
        //}
        public void GreetPeople(string name)
        {
            MakeGreet(name);
        }
    }
    class Program
    {
        public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning, " + name);
        }
        public static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }
        static void Main(string[] args)
        {
            GreetingManager gm = new GreetingManager( );
            gm.GreetPeople("mk", EnglishGreeting);
            gm.GreetPeople("lj", ChineseGreeting);
            Console.WriteLine("-----------------------------------------");
            GreetingDelegate delegate1;
            delegate1 = EnglishGreeting;
            delegate1 += ChineseGreeting;
            gm.GreetPeople("Jimmy Zhang", delegate1);
            Console.WriteLine("-----------------------------------------");
            //gm.delegate1  = ChineseGreeting;
            //gm.delegate1 += EnglishGreeting;
            //gm.delegate1 = new GreetingDelegate(EnglishGreeting);
            gm.delegate1 = ChineseGreeting;
            gm.GreetPeople("parkey", gm.delegate1);
            Console.WriteLine("-----------------------------------------");
            gm.GreetPeople("dy");
            gm.MakeGreet += ChineseGreeting;
            gm.MakeGreet += EnglishGreeting;
            Console.ReadLine( );


        }

        
    }
}

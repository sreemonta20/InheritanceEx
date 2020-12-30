using System;

namespace InheritanceEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Super oSuper = new Super();
            sub1 osub1 = new sub1();
            sub2 osub2 = new sub2();
            oSuper.Message();
            oSuper = osub1;
            oSuper.Message();
            osub1.Message();
            oSuper = osub2;
            osub2.Message();
            //osub1 =  osub2;
            //osub2 = osub1;
            //osub1 = oSuper;
            //osub2 = oSuper;
            Console.ReadLine();
        }
    }
}

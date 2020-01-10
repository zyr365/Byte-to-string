using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] byt1 = { 0x01, 0x11, 0x21,0xff ,0b0001_0001,0b0001_1111};//定义并初始化8位无符号字节数组
            foreach(var item in byt1)
              Console.Write(item+"**");//遍历并输出每个字节对应的十进制数值
            Console.WriteLine("\r");
            Console.WriteLine(BitConverter.ToString(byt1));//将字节数组转换为字符串并输出
            Console.WriteLine(BitConverter.ToString(byt1).Replace("-",""));//去掉连接符
            Console.ReadKey();
        }
    }
}

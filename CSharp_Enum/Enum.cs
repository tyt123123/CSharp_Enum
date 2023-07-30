using System;
using System.Runtime.CompilerServices;

namespace CSharp_Enum
{
    enum EMonster
    {
        Normal,
        Boss ,
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            #region 枚举类型在命名空间中声明
            //枚举不能在函数语句块中声明
            //枚举一般用来表示状体或了类型
            //枚举和switch 天生一对
            //在开发中，一个对象会有很多个状态，枚举的作用是用int数字代表每一个状态，且标识清晰  
            #endregion

            #region 使用

            EMonster normal = EMonster.Normal;
            EMonster boss = EMonster.Boss;
            switch (normal)
            {  
                case EMonster.Boss:
                    Console.WriteLine("大怪  ");
                    break;
                case EMonster.Normal:
                    break;
            }
            //枚举转int
            int enemy0 = (int)EMonster.Boss;
            int enemy1 = (int)boss;
            //枚举转string
            string na = normal.ToString();
            //string转枚举
            //parse后第一个参数转化为枚举类型，第二个参数是转换为对应的类型的字符串
            boss = (EMonster)Enum.Parse(typeof(EMonster), "Normal");
            Console.WriteLine((boss));
            EMonster enemy2 = (EMonster)Enum.Parse(typeof(EMonster), "Boss");
            Console.WriteLine((enemy2));

            #endregion
        }
    }
}
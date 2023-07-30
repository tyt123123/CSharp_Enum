using System;

namespace Ref_And_Out
{
    struct MyStruct
    {
        //变量,结构体中的变量不能直接初始化，类型任意，但不能是自己
        public string name;
        public int age;
        public bool sex;
        public int number;

        //构造函数（可选）
        public MyStruct(string name, int age, bool sex, int number)
        {
            //有参构造必须要把参数列表的内容初始化，且必须有参数
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.number = number;
        }

        //函数（表现数据行为）
        public  void Speak()
        {
            Console.WriteLine($"my name is :{name},and age is :{age}");
        }
        //修饰符必须为公开才会在构造体外被访问
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            #region 原因

            //值类型的参数赋值是浅拷贝
            //ref变量使用前必须初始化，out不用，out必须在函数内部赋值
            //params 关键字后的参数必为数组

            #endregion

            #region 结构体

            //数据与函数的结合，和枚举一样，写在命名空间下
            MyStruct myStruct;
            myStruct.age = 17;
            //// MyStruct myStruct1 = new MyStruct();
            //空参构造
            MyStruct myStruct2 = new MyStruct("千铃", 17, true, 10086);
            myStruct2.Speak();

            #endregion
        }
    }
}
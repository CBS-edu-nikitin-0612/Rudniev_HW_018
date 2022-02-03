using System;

namespace task3
{
    class Program
    {
        public static void ClassTaker(MyClass myClass)
            => myClass.change = "chenged";
        public static void StructTaker(MyStruct myStruct)
            => myStruct.change = "chenged";
        public static void StructTaker(ref MyStruct myStruct)
            => myStruct.change = "chenged";

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct1 = new MyStruct();
            MyStruct myStruct2 = new MyStruct();

            myClass.change = "not changed";
            myStruct1.change = "not changed";
            myStruct2.change = "not changed";

            ClassTaker(myClass);
            StructTaker(myStruct1);
            StructTaker(ref myStruct2);

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct1.change);
            Console.WriteLine(myStruct2.change);
        }
    }
}

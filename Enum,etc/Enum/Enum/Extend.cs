using System;


namespace Enum
{
    static class Extend
    {
        public static void Extension(this Practice a)
        {
            int i = 10;
            object obji = i;//boxing archive as value type is changed in ref type
                        //{ obji = obji+ 10};  can't add beacuse its converted into ref
            int j = (int)obji;//unboxing archive as ref typr is changed into value type

            Console.WriteLine("*****Boxing*****");
            Console.WriteLine("i is now converted in int: " + j);
            Console.ReadLine();
        }
    }
}

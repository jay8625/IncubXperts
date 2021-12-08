using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------CLONE----------");
            Console.WriteLine();
            string original = "jay";
            string clone = (string)original.Clone();    //  1
            Console.WriteLine("Clone is " + clone);
            Console.WriteLine();


            Console.WriteLine("----------Campare----------");
            Console.WriteLine();
            if (string.Compare(original, clone) == 0)  //  2
            {
                Console.WriteLine("Both are same");
            }
            else
            {
                Console.WriteLine("Unequal");
            }
            Console.WriteLine();

            Console.WriteLine("----------COMPAREORDINAL----------");
            Console.WriteLine();
            if (string.CompareOrdinal(original, clone) == 0)   //  3
            {
                Console.WriteLine("Both are same");
            }
            else
            {
                Console.WriteLine("Unequal");
            }
            Console.WriteLine();

            Console.WriteLine("----------COMPARETO----------");
            Console.WriteLine();
            int compare = clone.CompareTo(original);  //  4
            if (compare >= 0)
            {
                Console.WriteLine("String is Greater or equal to zero");
            }
            Console.WriteLine();

            Console.WriteLine("----------CONCAT----------");
            Console.WriteLine();
            string concat = string.Concat(compare, clone);  //  5
            Console.WriteLine("Concated string is " + concat);
            Console.WriteLine();

            Console.WriteLine("----------CONTAINS----------");
            Console.WriteLine();
            Console.WriteLine(original.Contains(clone));    //  6
            Console.WriteLine();

            Console.WriteLine("----------COPY----------");
            Console.WriteLine();
            string copy = string.Copy(concat);
            Console.WriteLine("Copy of String is " + copy);   //  7
            Console.WriteLine();

            Console.WriteLine("----------COPYTO----------");
            Console.WriteLine();
            string Word = "hello world how are you";    //  8
            char[] arry = new char[5];
            Word.CopyTo(0, arry, 0, 2);
            Console.WriteLine("copyto is implimented " + arry);
            Console.WriteLine();

            Console.WriteLine("----------ENDS_WITH----------");
            Console.WriteLine();
            Console.WriteLine("Endwith " + Word.EndsWith(original));  //  9
            Console.WriteLine();

            Console.WriteLine("----------EQUALS----------");
            Console.WriteLine();
            Console.WriteLine(clone.Equals(original));  //  10
            Console.WriteLine();

            Console.WriteLine("----------FORMAT----------");
            Console.WriteLine();
            string format = string.Format("{0} is the original,{1} is clone ", original, clone);    //  11
            Console.WriteLine(format);
            Console.WriteLine();


            Console.WriteLine("----------GET_ENUMERATOR----------");
            Console.WriteLine();
            CharEnumerator enu = original.GetEnumerator();   //  12
            while (enu.MoveNext())
            {
                Console.WriteLine("Enumarator : " + enu.Current);
            }
            Console.WriteLine();

            Console.WriteLine("----------GET_HASH_CODE----------");
            Console.WriteLine();
            Type hash = Word.GetType();
            TypeCode code = Type.GetTypeCode(hash);
            Console.WriteLine("hashcode is: " + hash.GetHashCode());  //13
            Console.WriteLine();

            Console.WriteLine("----------GET_TYPE----------");
            Console.WriteLine();
            Console.WriteLine("get type is: " + code);  //  14
            Console.WriteLine();

            Console.WriteLine("----------TYPE----------");
            Console.WriteLine();
            Console.WriteLine("type is: " + hash);  //  15
            Console.WriteLine();

            Console.WriteLine("----------INDEX_OF----------");
            Console.WriteLine();
            int index = original.IndexOf("i");
            Console.WriteLine("Index of i in Original is: " + index); //  16
            Console.WriteLine();

            Console.WriteLine("----------INSERT----------");
            Console.WriteLine();
            string insert = Word.Insert(4, "i");
            Console.WriteLine("insert res is= " + insert);    //  17
            Console.WriteLine();

            Console.WriteLine("----------INTERN----------");
            Console.WriteLine();
            string intern = string.Intern(original);
            Console.WriteLine("Intern res is: " + intern);    //  18
            Console.WriteLine();

            Console.WriteLine("----------IS_INTERNED----------");
            Console.WriteLine();
            string isinterned = string.IsInterned(Word);
            Console.WriteLine("Isinterned res is: " + isinterned);    //  19
            Console.WriteLine();

            Console.WriteLine("----------IS_NORMALIZED----------");
            Console.WriteLine();
            Console.WriteLine("normalised: " + Word.IsNormalized());  //  20
            Console.WriteLine();

            Console.WriteLine("----------IS_NULL_OR_EMPTY----------");
            Console.WriteLine();
            Console.WriteLine("Not null :" + string.IsNullOrEmpty(Word)); //  21
            Console.WriteLine();

            Console.WriteLine("----------NULL_OR_WHITESPACE----------");
            Console.WriteLine();
            Console.WriteLine("null or White space: " + string.IsNullOrWhiteSpace(Word)); //  22
            Console.WriteLine();

            Console.WriteLine("----------JOIN----------");
            Console.WriteLine();
            string join = string.Join(Word, original);
            Console.WriteLine("Joined is: " + join);  //  23
            Console.WriteLine();

            Console.WriteLine("----------LAST_INDEX----------");
            Console.WriteLine();
            string strings = "j@y,jayesh,siddesh,omakar";
            Console.WriteLine("last index: " + strings.LastIndexOf(','));   //  24
            Console.WriteLine();

            Console.WriteLine("----------LAST_INDEXOF_ANY----------");
            Console.WriteLine();
            char[] last = new char[10];
            last[0] = 'j';
            last[1] = 'a';
            last[2] = 'y';
            Console.WriteLine("last index of any: " + strings.LastIndexOfAny(last, 2));   //  25
            Console.WriteLine();

            Console.WriteLine("----------NORMALIZE----------");
            Console.WriteLine();
            Console.WriteLine("Normalization is: " + original.Normalize());   //  26
            Console.WriteLine();

            Console.WriteLine("----------PADLEFT----------");
            Console.WriteLine();
            Console.WriteLine("pad left" + Word.PadLeft(10));   //  27
            Console.WriteLine();

            Console.WriteLine("----------PADRIGHT----------");
            Console.WriteLine();
            Console.WriteLine("pad right" + Word.PadRight(4));    //  28
            Console.WriteLine();

            Console.WriteLine("----------REMOVE----------");
            Console.WriteLine();
            Console.WriteLine("Remove " + original.Remove(2));    //  29
            Console.WriteLine();

            Console.WriteLine("----------REPLACE----------");
            Console.WriteLine();
            Console.WriteLine("replace " + original.Replace("i", "y"));    //  30
            Console.WriteLine();

            Console.WriteLine("----------SPLIT BY COMMA----------");
            Console.WriteLine();
            string split = "jay fegade,2000@30";
            string[] splited1 = split.Split(',');
            Console.Write("Split by comma : ");      //  31
            foreach (string str in splited1)
            { Console.WriteLine(str); }
            Console.WriteLine();

            Console.WriteLine("----------SPLIT BY SPACE----------");
            Console.WriteLine();
            string[] splited2 = split.Split(' ');
            Console.Write("Split by space : ");      //  32
            foreach (string str in splited2)
            { Console.WriteLine(str); }
            Console.WriteLine();


            Console.WriteLine("----------SPLIT BY @----------");
            Console.WriteLine();
            string[] splited3 = split.Split('@');
            Console.Write("Split by @ : ");      //  33
            foreach (string str in splited3)
            { Console.WriteLine(str); }
            Console.WriteLine();

            Console.WriteLine("----------START_WITH----------");
            Console.WriteLine();
            Console.WriteLine("StartsWith : {0} ", Word.StartsWith("S"));   //  34
            Console.WriteLine();

            Console.WriteLine("----------SUBSTRING----------");
            Console.WriteLine();
            Console.WriteLine("StartsWith : {0} ", Word.Substring(6));   // 35
            Console.WriteLine();

            Console.WriteLine("----------TO CHAR ARRY----------");
            Console.WriteLine();
            char[] convert = Word.ToCharArray();
            Console.WriteLine("CharArray: " + convert);   //  36
            Console.WriteLine();

            Console.WriteLine("----------TO.LOWER----------");
            Console.WriteLine();
            string lower = "JAI FEGDE";
            Console.WriteLine("Upper to lower " + lower.ToLower());   //  37
            Console.WriteLine();

            Console.WriteLine("----------TO.LOWERINVARIANT----------");
            Console.WriteLine();
            Console.WriteLine("To lower invariant: " + lower.ToLowerInvariant()); //38
            Console.WriteLine();

            Console.WriteLine("----------TO STRING----------");
            Console.WriteLine();
            int tostring = 1231344;
            Console.WriteLine("int to string: " + tostring.ToString());   //  39
            Console.WriteLine();

            Console.WriteLine("----------TO.UPPER----------");
            Console.WriteLine();
            string upper = "jai fegde##";
            Console.WriteLine("lower to upper " + upper.ToUpper());   //  40
            Console.WriteLine();

            Console.WriteLine("----------TRIM----------");
            Console.WriteLine();
            Console.WriteLine("trim: " + upper.Trim('#'));    //  41
            Console.WriteLine();

            Console.WriteLine("----------TRIM START----------");
            Console.WriteLine();
            string trimming = "##jay##";
            Console.WriteLine("Start trim: " + trimming.TrimStart('#'));  // 42
            Console.WriteLine();

            Console.WriteLine("----------TRIM_END----------");
            Console.WriteLine();
            Console.WriteLine("end trim: " + trimming.TrimEnd('#'));  //  43
            Console.WriteLine();


            Console.WriteLine("##########********************STRING BUILDER********************##########");
            Console.WriteLine();


            Console.WriteLine("----------STRING BUILDER----------");
            Console.WriteLine();
            StringBuilder stringBuilder = new StringBuilder("hello");
            Console.WriteLine("Original: " + stringBuilder);
            Console.WriteLine();

            Console.WriteLine("----------STRING APPEND----------");
            Console.WriteLine();
            stringBuilder.Append(" World");
            Console.WriteLine("After append: " + stringBuilder);
            Console.WriteLine();

            Console.WriteLine("----------APPEND FORMAT----------");
            Console.WriteLine();
            Console.WriteLine(stringBuilder.AppendFormat(" format done "));
            Console.WriteLine();

            Console.WriteLine("----------INSERT----------");
            Console.WriteLine();
            stringBuilder.Insert(5, "good morning ");
            Console.WriteLine("After insert: " + stringBuilder);
            Console.WriteLine();

            Console.WriteLine("----------REMOVE----------");
            Console.WriteLine();
            stringBuilder.Remove(3, 6);
            Console.WriteLine("after remove: " + stringBuilder);
            Console.WriteLine();

            Console.WriteLine("----------REPLACE----------");
            Console.WriteLine();
            stringBuilder.Replace("hello", " good");
            Console.WriteLine("After replace: " + stringBuilder);
            Console.WriteLine();

            Utilities Exception = new Utilities();
            Console.WriteLine("**********ZERO EXCEPTION**********");
            Console.WriteLine();
            
            Exception.Divide();
            Console.WriteLine();
            Console.WriteLine("**********FORMAT EXCEPTION**********");
            Console.WriteLine();
            
            Exception.StringConvert();
            Console.WriteLine();
            Console.WriteLine("**********INDEX OUT OF RANGE**********");
            Console.WriteLine();
            
            Exception.ArryExecption();
            Console.WriteLine();
            Console.WriteLine("**********MULTIPLE CATCH & FINAL BLOCK**********");
            Console.WriteLine();
            Exception.MultiCatch();

            Console.ReadLine();
        }
    }
}

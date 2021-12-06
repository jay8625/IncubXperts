using System;


namespace Enum
{
    class Practice
    {
        public int width;
        static int height;


        private static void Height()    //static member example
        {
            height = 200;   //This will be Constant for whole methods Therefore its static 
        }
        public Practice(int wid)    //Parameterise Constructure
        {
            this.width = wid;
        }

        public Practice(string a)   //Overloaded Constructure
        {
            Console.WriteLine("This is a Overloaded Constructor");
        }

        public Practice()   //User define Constructor
        {
        }

        public Practice(Practice A)
        {

        }

        public void CrossSection(int a)     
        {
            Console.WriteLine("Cross-Section Area is: " + a + height);
        }
        

        
        public void Value(int x)    //call by value
        {
            x +=10;
            Console.WriteLine("value when called the method "+x);
        }

        public static void Referance(ref int x)     //call by referance
        {
            x += 10;
            Console.WriteLine("value when called the method " + x);
        }


    }
    public enum Direction   //enum Example
    {
        North = 1, East, South, West
    }
}

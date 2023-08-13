
namespace Program1{
class Cal
{
    static void Main(string[] args)
    {
            // we need to make instance object declaration to call noneStaticMethods
            // new Cal();  -> is the making instance object declaration
            new Cal().NoneStaticMethod();

            //just same with the first.
            new SecondClass().SecondNoneStaticMethod();

            // we don't need above steps in calling Static Methods.

            StaticMethod();
            // need class name for accessing static method from another class
            SecondClass.SecondStaticMethod();  
    }

        void NoneStaticMethod()
        {
            Console.WriteLine("Hey, I am None Static Method in same class");
        }

        static void StaticMethod()
        {
            Console.WriteLine("Hey, I am Static Method in same class");
        }
}

    class SecondClass
    {
        // Access Modifier => default is Private => So, declare to public to access from another class
        public void SecondNoneStaticMethod()
        {
            Console.WriteLine("Hey, I from Second Class and NoneStatic Method");
        }
       public static void SecondStaticMethod()
        {
            Console.WriteLine("Hey, I from Second Class and Static Method");
        }
    }
}



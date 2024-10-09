namespace AccessModifiersExample
{//Namespace starting here
 //  Note:namespace contain collection of classes
 //same class
 //If you are not specifing the access modifier to the class.defaulty it takes Internal accessmodier.
    class Class1
    { //class starts here 
      //accessmodifiers datatype variablename;
      //If you are not specifing the access modifier to the variable or method.defaulty it takes private.
        int Z = 100;//here deafullt accessmodier for this variable is private.
        private int a; //private member
        protected int b; //protected member
        internal int c; //internal member
        protected internal int d; //protected internal member
        public int e; //public member
//In same class we can access all accessmodiiers...
        public void Method1()
        {
            a = 10; //private member is accessible in the same class
            b = 20; //protected member is accessible in the same class
            c = 30; //internal member is accessible in the same class
            d = 40; //protected internal member is accessible in the same class
            e = 50; //public member is accessible in the same class
            this.a = 100;
            this.b = 30;
            this.c = 50;
            this.d = 60;
            this.e = 60;

        }
    }//class ends here

    //child class in the same project
    // In the child classes at the sameproject
    //class childclassname:parentclassname
    class Class2: Class1
    {
        //Except private ,remaing all access modifiers we can ACCESS.
        public void Method2()
        {
           // a = 100;***************we can't access private data member in out side class
            b = 20; //protected member is accessible in the child class at same project
            c = 30; //internal member is accessible in the child class at same project
            d = 40; //protected internal member is accessible in the child class at same project
            e = 50; //public member is accessible in the child class at same project
        }
    }

    //other class in the same project
    class Class3
    {
        public void Method3()
        {
            Class1 c1 = new Class1();
            //here we can't access private and protected members.
            c1.c = 30; //internal member is accessible in the other class at same project
            c1.d = 40; //protected internal member is accessible in the other class at same project
            c1.e = 50; //public member is accessible in the other class at same project
        }
    }

    //other class in the same project
    class Program
    {
        static void Main()
        {
            Class1 c1 = new Class1();
            c1.c = 30; //internal member is accessible in the other class at same project
            c1.d = 40; //protected internal member is accessible in the other class at same project
            c1.e = 50; //public member is accessible in the other class at same project

            System.Console.WriteLine("Done");
            System.Console.ReadKey();
        }
    }
}//Namespace Ending here




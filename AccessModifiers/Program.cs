using System;

namespace AccessModifiers
{
    using System;

    public class MyClass
    {
       
        public int publicField = 10;

  
        private int privateField = 20;

        protected int protectedField = 30;

        internal int internalField = 40;

        public void PublicMethod()
        {
            Console.WriteLine("Public method called");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private method called");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method called");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal method called");
        }
    }

    public class DerivedClass : MyClass
    {
        public void AccessProtectedField()
        {
            Console.WriteLine("Protected field accessed from derived class: " + protectedField);
        }

        public void AccessProtectedMethod()
        {
            ProtectedMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            MyClass myObject = new MyClass();

            Console.WriteLine("Public field value: " + myObject.publicField);
            myObject.PublicMethod();

            Console.WriteLine("Internal field value: " + myObject.internalField);
            myObject.InternalMethod();

    
            DerivedClass derivedObject = new DerivedClass();

            derivedObject.AccessProtectedField();
            derivedObject.AccessProtectedMethod();
        }
    }

}

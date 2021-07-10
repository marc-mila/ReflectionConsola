using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionConsola
{
    class MyMainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nReflection.MethodInfo");
            //create MyClass object
            Type type1 = typeof(MyClass);
            object obj = Activator.CreateInstance(type1);
            //get the type information
            Type myTypeObj = obj.GetType();
            Console.WriteLine("Type fullname: " + myTypeObj.FullName);
            //get the method information
            MethodInfo myMethodInfo = type1.GetMethod("AddNumb");
            object[] mParam = new object[] { 5, 10};
            //get and display the Invoke method
            Console.WriteLine("\nFirst method - " + type1.FullName + " returns " +
                myMethodInfo.Invoke(obj, mParam) + "\n");

            
            Console.WriteLine(typeof(MyClass).AssemblyQualifiedName);

            Console.WriteLine("\nReflection.MethodInfo with string");
            Type type2 = Type.GetType("ReflectionConsola.MyClass, ReflectionConsola");
            object obj2 = Activator.CreateInstance(type2);
            //get the type information
            Type myTypeObj2 = obj2.GetType();
            Console.WriteLine("Type Fullname: " + myTypeObj2.FullName);
            //get the method information
            MethodInfo myMethodInfo2 = type2.GetMethod("AddNumb");
            object[] mParam2 = new object[] { 5, 10};
            //get and display the Invoke method
            Console.WriteLine("\nFirst method - " + type2.FullName + " returns " +
                myMethodInfo.Invoke(obj2, mParam2) + "\n");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Stepan", 18, 187.5, false, new DateTime(2023, 3, 5));

            Type personType = person.GetType();
            TypeInfo typeInfo = personType.GetTypeInfo();

            Console.WriteLine("********MemberInfo********");

            MemberInfo[] memberInfoList = personType.GetMembers();
            foreach (MemberInfo memberInfo in memberInfoList) { Console.WriteLine(memberInfo); }

            Console.WriteLine("********FieldInfo********");

            FieldInfo[] fieldInfoList = personType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance
                | BindingFlags.Public);
            foreach (FieldInfo fieldInfo in fieldInfoList) { Console.WriteLine(fieldInfo); }

            Console.WriteLine("********MethodInfo********");

            IEnumerable<MethodInfo> methods = typeInfo.DeclaredMethods;
            foreach (MethodInfo methodInfo in methods)
            {
                Console.WriteLine(methodInfo.DeclaringType.Name + ": " + methodInfo.Name);
            }

            Console.WriteLine("********MethodInfo GetMethod********");

            MethodInfo sayHelloMethod = personType.GetMethod("SayHello");
            string sayHelloMethodResult = (string)sayHelloMethod.Invoke(person, null);
            Console.WriteLine(sayHelloMethodResult);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectionPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load Assemblies Method
            //Assembly assemb1 = Assembly.Load("System.dll"); //Load by Name, usually from GAC
            //Assembly assemb2 = Assembly.LoadFile(@"C:\Program Files\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.dll"); //Load by path
            //Assembly assemb3 = Assembly.LoadFrom("C:\\abc.dll"); //Load by path

            //Once assembly is loaded,we now can create instance of a type by calling assembl.GetType();            
            //Type t = assemb2.GetType("System.String");

            
            // Create a Type instance.
            // Typically, this would be done by loading an external assembly,
            // and then calling Assembly.GetType()
            Type t = typeof(StringBuilder);

            // Create a ConstructorInfo instance that will allow us to create an
            // instance of the Type we just loaded.
            // GetConstructor requires a list of parameters in a Type array
            // that match those required by the constructor.
            // This example represents the StringBuilder constructor that
            // requires a single parameter.
            ConstructorInfo ci = t.GetConstructor(new Type[] { typeof(string) });
            // Create an instance of the type by calling ConstructorInfo.Invoke.
            // Provide the parameters required by the constructor: a single string.
            // This creates a StringBuilder instance.
            Object sb = ci.Invoke(new Object[] { "Hello, " });

            // Create a MethodInfo instance representing the StringBuilder.Append method.
            // GetMethod requires the first parameter to be the name of the method.
            // The second parameter is a Type array representing the parameters required
            // by the method. We're using the Append overload that requires a single string.
            MethodInfo sbAppend = t.GetMethod("Append", new Type[] { typeof(string) });
            // Call StringBuilder.Append and provide a single parameter: the string "world!".
            Object result = sbAppend.Invoke(sb, new Object[] { "world!" });

            // Create a PropertyInfo instance representing the StringBuilder.Length property.
            PropertyInfo lengthProperty = t.GetProperty("Length");
            // Retrieve the Length property and cast it to the native type.
            int length = (int)lengthProperty.GetValue(sb, null);

            MemberInfo[] mi = t.GetMembers(BindingFlags.NonPublic | BindingFlags.Static);
            foreach (MemberInfo m in mi)
            {
                Console.WriteLine("{0}: {1}", m.Name, m.MemberType);
            }

            //To play with current assembly

            Assembly asm = Assembly.GetExecutingAssembly();
            foreach (Attribute attr in asm.GetCustomAttributes(false))
            {
                if (attr.GetType() == typeof(AssemblyCopyrightAttribute))
                    Console.WriteLine("Copyright: {0}",
                    ((AssemblyCopyrightAttribute)attr).Copyright);
                if (attr.GetType() == typeof(AssemblyCompanyAttribute))
                    Console.WriteLine("Company: {0}",
                    ((AssemblyCompanyAttribute)attr).Company);
                if (attr.GetType() == typeof(AssemblyDescriptionAttribute))
                    Console.WriteLine("Description: {0}",
                    ((AssemblyDescriptionAttribute)attr).Description);
            }
        }
    }
}

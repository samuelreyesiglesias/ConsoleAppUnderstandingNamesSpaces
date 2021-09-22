using System;
using System.CodeDom;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Resources;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Timers;
using System.Transactions;
using System.Web;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32.SafeHandles;
using Microsoft.Win32;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Resolvers;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Windows.Input;
using System.Windows.Markup;
using System.Security;

namespace ConsoleAppUnderstandingNamesSpaces
{

    class Program
    {
        static void Main(string[] args)
        {
          

            NameSpaceOne.MyClass NewClassInstance = new NameSpaceOne.MyClass();
            int IntegerValue=NewClassInstance.MyProperty;

            NameSpaceTwo.MyClass NewClassInstanceFromNamesPace2 = new NameSpaceTwo.MyClass();
            int IntegerValueInstance2 = NewClassInstanceFromNamesPace2.MyProperty;

            NameSpaceOneHundred.testingClass InstanceFromNamesPaceOneHundred = new NameSpaceOneHundred.testingClass();
            int ValueFromNewInstance = InstanceFromNamesPaceOneHundred.MyProperty;

            //Here i can instance the external class when i assign the 3 objects..
            UsingExternalNamesSpacesClassNumberTwo NExternalClass = new UsingExternalNamesSpacesClassNumberTwo();
            Console.WriteLine($"The value of first instace is:{NExternalClass.ClassN1.MyProperty.ToString()}");
            Console.WriteLine($"The value of second instace is:{NExternalClass.ClassN2.MyProperty.ToString()}");
            Console.WriteLine($"The value of third instace is:{NExternalClass.ClassN3.MyProperty.ToString()}");

            Console.WriteLine("Hello World!");
            
        }

    }
}

namespace NameSpaceOne
{
    class MyClass
    {
        public int MyProperty { get; set; } = 3000;
    }
}

namespace NameSpaceTwo
{

    class MyClass
    {
        public int MyProperty { get; set; } = 30;
    }
}

namespace NameSpaceOneHundred
{

    class testingClass
    {
        public int MyProperty { get; set; } = 20;
    }

}
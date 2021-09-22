using System;
using System.Collections.Generic;
using System.Text;
using NameSpaceOne;
//IF I HAVE 3 CLASSES WITH THE SAME NAME, THAT IS AMBIGOUS TO ISNTANCE,
//THE SOLUTION TO IT, IS PROVIDE AN ALIAS IN THE IMPORTING NAMESPACES 
//HERE I GIVE YOU THE SOLUCTION
using MyClass1 = NameSpaceOne.MyClass ;
using MyClass2 = NameSpaceTwo.MyClass;
using MyClass3 = NameSpaceOneHundred.testingClass;

namespace ConsoleAppUnderstandingNamesSpaces
{
    class UsingExternalNamesSpacesClassNumberTwo
    {
        
        public MyClass1 ClassN1 = new MyClass1();
        public  MyClass2 ClassN2 = new MyClass2();
        public MyClass3 ClassN3 = new MyClass3();

    }
}

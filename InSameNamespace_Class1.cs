using System;
using System.Collections.Generic;
using System.Text;

namespace InSameNamespace
{
    class InSameNamespace_Class1
    {
        public int MyPropertyShared1 { get; set; } = 500;
    }
    class UsingCodeFromTwoClassesInSameNameSpace
    {
        InSameNamespace_Class1 Cl1 = new InSameNamespace_Class1();
        InSameNamespace_Class2 Cl2 = new InSameNamespace_Class2();
        //I dont need to import namespaces because they are in the same..
    }
}

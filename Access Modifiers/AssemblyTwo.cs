using System;

namespace Access_Modifiers
{
    public class AssemblyTwo
    {
        public void Test()
        {
            AssemblyOne A1 = new AssemblyOne();
            A1.Print();
        }
    }
}

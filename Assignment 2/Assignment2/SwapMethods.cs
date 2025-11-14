using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class SwapMethods
    {
        // Method 1: Swap two doubles by value (won't work)
        public void SwapDoublesByValue(double a, double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        // Method 2: Swap two doubles by reference (will work)
        public void SwapDoublesByRef(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        // Method 3: Swap two strings by value (won't work)
        public void SwapStringsByValue(string str1, string str2)
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
        }

        // Method 4: Swap two strings by reference (will work)
        public void SwapStringsByRef(ref string str1, ref string str2)
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
        }

        // Method 5: Swap two Student objects by value (won't work)
        public void SwapStudentsByValue(Student student1, Student student2)
        {
            Student temp = student1;
            student1 = student2;
            student2 = temp;
        }

        // Method 6: Swap two Student objects by reference (will work)
        public void SwapStudentsByRef(ref Student student1, ref Student student2)
        {
            Student temp = student1;
            student1 = student2;
            student2 = temp;
        }
    }
}

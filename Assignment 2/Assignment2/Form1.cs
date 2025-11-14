namespace Assignment2
{
    public partial class Form1 : Form
    {
        private SwapMethods swapMethods;

        public Form1()
        {
            InitializeComponent();
            swapMethods = new SwapMethods();
        }

        // Test double swaps
        private void testDoublesButton_Click(object sender, EventArgs e)
        {
            string result = "=== TESTING DOUBLE SWAPS ===\n\n";

            // Test by value
            double d1 = 10.5;
            double d2 = 20.7;
            result += "CALL BY VALUE:\n";
            result += $"Before swap: d1 = {d1}, d2 = {d2}\n";
            swapMethods.SwapDoublesByValue(d1, d2);
            result += $"After swap:  d1 = {d1}, d2 = {d2}\n";
            result += "Result: Values NOT swapped\n\n";

            // Test by reference
            d1 = 10.5;
            d2 = 20.7;
            result += "CALL BY REFERENCE:\n";
            result += $"Before swap: d1 = {d1}, d2 = {d2}\n";
            swapMethods.SwapDoublesByRef(ref d1, ref d2);
            result += $"After swap:  d1 = {d1}, d2 = {d2}\n";
            result += "Result: Values SUCCESSFULLY swapped";

            MessageBox.Show(result, "Double Swap Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Test string swaps
        private void testStringsButton_Click(object sender, EventArgs e)
        {
            string result = "=== TESTING STRING SWAPS ===\n\n";

            // Test by value
            string str1 = "Hello";
            string str2 = "World";
            result += "CALL BY VALUE:\n";
            result += $"Before swap: str1 = \"{str1}\", str2 = \"{str2}\"\n";
            swapMethods.SwapStringsByValue(str1, str2);
            result += $"After swap:  str1 = \"{str1}\", str2 = \"{str2}\"\n";
            result += "Result: Strings NOT swapped\n\n";

            // Test by reference
            str1 = "Hello";
            str2 = "World";
            result += "CALL BY REFERENCE:\n";
            result += $"Before swap: str1 = \"{str1}\", str2 = \"{str2}\"\n";
            swapMethods.SwapStringsByRef(ref str1, ref str2);
            result += $"After swap:  str1 = \"{str1}\", str2 = \"{str2}\"\n";
            result += "Result: Strings SUCCESSFULLY swapped";

            MessageBox.Show(result, "String Swap Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Test Student object swaps
        private void testStudentsButton_Click(object sender, EventArgs e)
        {
            string result = "=== TESTING STUDENT OBJECT SWAPS ===\n\n";

            // Test by value
            Student student1 = new Student("Alice", 20);
            Student student2 = new Student("Bob", 22);
            result += "CALL BY VALUE:\n";
            result += $"Before swap: student1 = {student1}\n";
            result += $"             student2 = {student2}\n";
            swapMethods.SwapStudentsByValue(student1, student2);
            result += $"After swap:  student1 = {student1}\n";
            result += $"             student2 = {student2}\n";
            result += "Result: Student objects NOT swapped\n\n";

            // Test by reference
            student1 = new Student("Alice", 20);
            student2 = new Student("Bob", 22);
            result += "CALL BY REFERENCE:\n";
            result += $"Before swap: student1 = {student1}\n";
            result += $"             student2 = {student2}\n";
            swapMethods.SwapStudentsByRef(ref student1, ref student2);
            result += $"After swap:  student1 = {student1}\n";
            result += $"             student2 = {student2}\n";
            result += "Result: Student objects SUCCESSFULLY swapped";

            MessageBox.Show(result, "Student Swap Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

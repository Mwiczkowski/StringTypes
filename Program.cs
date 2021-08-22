using System;
using System.Text;

namespace StringTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sbPopularSeries = new StringBuilder("Popular Series"); //List of strings that contains many values inside of it, in this case those are the names of the popular tv series
            sbPopularSeries.Append("\n");
            sbPopularSeries.AppendLine("The Witcher");
            sbPopularSeries.AppendLine("Friends");
            sbPopularSeries.AppendLine("Lucifer");
            sbPopularSeries.AppendLine("Prison Break 5");
            Console.WriteLine(sbPopularSeries.ToString());
            sbPopularSeries.Replace("5", " The Last Escape"); //Replaces the 5 for The last Escape
            Console.WriteLine(sbPopularSeries.ToString());
            Console.WriteLine("sb has {0} characters\n\n\n", sbPopularSeries.Length); //Counts the number of characters that sbPopularseries titles contains


            string n1 = "Miłosz";
            Console.WriteLine("n1 = {0}", n1);
            string upperString = n1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);
            Console.WriteLine("n1 = {0}\n\n\n", n1);


            string c1 = "Hello";
            string c2 = "Hi";
            Console.WriteLine("c1 = {0}", c1); //Console.System returns first what is written in quotation marks as text then the position c1 as {0}
            Console.WriteLine("c2 = {0}", c2);
            Console.WriteLine("c1 == c2: {0}", c1 == c2); //Comparing strings if they have the same value on different ways, check this line and below
            Console.WriteLine("c1 == Hello: {0}", c1 == "Hello");
            Console.WriteLine("c1 == HELLO: {0}", c1 == "HELLO");
            Console.WriteLine("c1 == hello: {0}", c1 == "hello");
            Console.WriteLine("c1.Equals(c2): {0}", c1.Equals(c2));
            Console.WriteLine("Hi.Equals(c2): {0}\n\n\n", "Hi".Equals(c2));


            string strWithTabs = "Model\tColor\tSpeed\tName\t"; //Use '\t' to create a pause (tab space) between text in the same line
            Console.WriteLine($"\n{strWithTabs}");
            Console.WriteLine("Everyone wrote a program displaying the text \"Hello World\""); //Use '\"TextHere\"' to add quotation marks to the text, outcome: "TextHere"
            Console.WriteLine(@"Everyone wrote a program displaying the text ""Hello World"""); //Use of double quotation marks on Hello World text with the sign @ instead of \"TextHere\"
            Console.WriteLine("C:\\StringTypes\\Bin\\Debug"); //This is the option to write directory using double '\'
            Console.WriteLine(@"C:\StringTypes\Bin\Debug"); //This is the option to skip using double '\' and display information as it is
            Console.WriteLine("Koniec.\n\n"); //Use '\n\' to create an empty row between the text in the console
            Console.WriteLine(); //You can use also this command to create an empty row in between the text, type 'cw' and press tab twice


            string firstName = "Miłosz";
            string lastName = " Wiczkowski";
            string s1 = firstName + lastName; //Easy sum up of two variables that are later displayed as a sum s1
            Console.WriteLine(s1);
            string s2 = string.Concat(firstName, lastName); //Concatenation, which means displaying two variables in the corresponding order (firstName, lastName) of type string as it is declared
            Console.WriteLine($"{s2}\n\n\n");


            Console.WriteLine("Value of variable firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters", firstName.Length); //Calculates the length of firstName
            Console.WriteLine("firstName written in uppercase: {0}", firstName.ToUpper()); //Displays firstName in UPPERCASE
            Console.WriteLine("firstName written in lower case: {0}", firstName.ToLower()); //Displays firstName in lower case
            Console.WriteLine("Does firstName contain letter i? {0}", firstName.Contains("i")); //Returns true or false if firstName contains letter 'i'
            Console.WriteLine("firstName after letter change: {0}", firstName.Replace("z", "zek")); //Replaces every letter 'z' in firstName for 'zek' which is an abreviation of name Miłosz

        }
    }
}

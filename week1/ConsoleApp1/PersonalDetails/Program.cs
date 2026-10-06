namespace PersonalDetails
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO 1: declare one variable per detail.
            //         Text uses string, a whole number uses int.
            //         The first one is done for you.
            string name = "Swoyam Pradhan";

            // TODO 2: declare a variable for the address, contact number,
            //         email, college, course, and year of study.
            string address ="Belchautara";
            string contactNumber = "9864435038";
            string email ="pradhanswoyam2003@gmail.com";
            string college ="ICP";
            string course ="BIT";
            int yearOfStudy = 1;


            // TODO 3: print a heading line, then one labelled line per detail.
            //         The first two are done for you as a model.
            Console.WriteLine("========== Personal Details ==========");
            Console.WriteLine($"Name          : {name}");

            // TODO 4: print a line for every remaining detail.
            Console.WriteLine($"Address       : {address}");
            Console.WriteLine($"Contact No.   : {contactNumber}");
            Console.WriteLine($"Email         : {email}");
            Console.WriteLine($"College       : {college}");
            Console.WriteLine($"Course        : {course}");
            Console.WriteLine($"Year of Study : {yearOfStudy}");
        }
    }
}

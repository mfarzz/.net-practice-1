namespace SeriesA
{
    //Method, membungkus statement's (beberapa kode). fungsinya hampir mirip seperti variabel tapi ini untuk sebuah fungsi
    //void, method yang tidak mengembalikan nilai
    //non-void, method yang mengembalikan nilai
    //void bagus digunakan ketika memberikan untuk hanya output sesuatu
    //non void bagus digunakan selain print
    public class GMethod
    {
        public static void Introduction()
        {
            Console.WriteLine("Full Name: Muhammad Fariz");
            Console.WriteLine("Job Position: Application Developer");
        }

        public static void WhoAreYou(string fullName, string position)
        {
            Console.WriteLine("Hello, my name is " + fullName + " and I am " + position + ".");
        }

        public static string FullName(string firsName, string lastName)
        {
            return firsName + " " + lastName;
        }

        public static int BirthDate(int year, int month, int day)
        {
            DateTime birthDate = new DateTime(year, month, day);
            DateTime now = DateTime.Now;
            return now.Year - birthDate.Year;
        }
    }
}

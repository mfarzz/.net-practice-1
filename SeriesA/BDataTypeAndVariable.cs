namespace SeriesA
{
    public class BDataTypeAndVariable
    {
        /*
         * Variabel, menampung suatu nilai. Tujuannya agar value bisa digunakan secara berulang
         * Data Type, format penampung untuk penyimpanan value, bisa berisi rentang tertentu atau bisa suatu tipe
         * Value, nilai yang dapat dimanipulasi oleh program
         * 
         * Penulisan Variabel
         * >Explicit
         * Format:
         * DataType Variable
         * Variabel = Value
         * 
         * >Implicit
         * Format:
         * DataType Variable = Value
         */

        public static void Variable()
        {
            // Deklarasi
            string fullName;
            char gender;
            int age;
            float gPA;
            bool isActive;

            // Inisialisasi
            fullName = "Muhammad Fariz";
            gender = 'M';
            age = 22;
            gPA = 3.87f;
            isActive = true;

            // Print
            Console.WriteLine(fullName);
            Console.WriteLine(gender);
            Console.WriteLine(age);
            Console.WriteLine(gPA);
            Console.WriteLine(isActive);
        }

        // Contant, tampungan yang tidak dapat diubah nilai ketika ditentukan
        public static void Constant()
        {
            const float phi = 3.14f;
        }

        /*
         * Array, dapat menampung beberapa nilai dengan tipe data yang sama
         * Array dibagi menjadi 3 = indexed, multidimentional, associative
         * Syarat arrray adalah panjang array bersifat tetap dan harus ditentukan pada deklarasi awal. tidak bisa ditambah atau dikurang
         * 
         * Untuk menampilkan array dimulai dari index ke 0
         */

        public static void Array()
        {
            // One-dimensional
            string[] studyProgram = { "IT", "CS", "IS", "GD" };
            string[] masterProgram = new string[2];

            masterProgram[0] = "Science";
            masterProgram[1] = "Business Administration";

            foreach (var s in masterProgram)
            {
                Console.WriteLine(s);
            }

            // Multi-dimensional array
            string[,] fullNames = new string[2, 3];
            string[,] masterNames =
            {
                {"1","2"},
                {"3", "4"}
            };

            Console.WriteLine(masterNames[0, 0]);
            Console.WriteLine(masterNames[1, 0]);
            Console.WriteLine(masterNames[0, 1]);
            Console.WriteLine(masterNames[1, 1]);

            Extra();
        }

        public static void Extra()
        {
            string fullName = "Muhammad Fariz";
            int age = 22;
            // String Interpolation
            Console.WriteLine($"FullName : {fullName} Age : {age}");

            // Input Text
            Console.Write("Masukkan nama : ");
            string text = Console.ReadLine();
            Console.WriteLine(text);

            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);

            Console.Clear();
        }
    }
}

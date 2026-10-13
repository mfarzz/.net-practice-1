namespace SeriesA
{
    // Condition, Evaluasi boolean berdasarkan syarat/kondisi
    public class ECondition
    {
        public static void IfCondition()
        {
            bool isActive = true;
            float gPA = 3.4f;
            float studyPeriod = 5;


            if (!isActive)
            {
                Console.WriteLine("Aktf");
            }
            else
            {
                Console.WriteLine("Tidak Aktif");
            }


            if (gPA > 3.9f && studyPeriod < 4)
            {
                Console.WriteLine("Summa Cumlaude");
            }
            else if (gPA < 3.5f && studyPeriod < 4)
            {
                Console.WriteLine("Cumlaude");
            }
            else
            {
                Console.WriteLine("Lulus");
            }

            if (studyPeriod < 4)
            {
                if (gPA > 3.9f)
                {
                    Console.WriteLine("Summa Cumlaude");
                }
                else if (gPA < 3.5f)
                {
                    Console.WriteLine("Cumlaude");
                }
            }
            else if (studyPeriod == 4)
            {
                Console.WriteLine("Lulus");
            }
            else
            {
                Console.WriteLine("Lulus sedikit terlambat");
            }
        }
        public static void SwitchCondition()
        {
            int month = 5;
            string monthName;

            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                default:
                    monthName = "Bukan nama bulan";
                    break;
            }
            Console.WriteLine(monthName);
        }
    }

}

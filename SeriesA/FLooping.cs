namespace SeriesA
{
    //Looping, mengulang statement sapai kondisi berakhir
    public class FLooping
    {
        public static void ForLoop()
        {
            /*
             * Format
             * for (init; condition; operator) {
             *      statement
             * }
             */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Counter : " + i);
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int number in numbers)
            {
                Console.WriteLine("No " + number);
            }
        }

        // Ketika kondisi tidak menentu atau dinamis
        public static void WhileLoop()
        {
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("Counter : " + counter);
                counter++;
            }

            do
            {
                Console.WriteLine("Counter : " + counter);
                counter++;
            }
            while (counter < 10);
        }
    }
}

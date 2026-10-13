namespace SeriesA
{
    public class DOperator
    {
        public static void Arithmatic()
        {
            int x = 3;
            int y = 5;

            int add = x + y;
            int multiply = x * y;
            int divide = x / y;
            int substract = x - y;
            int modulus = x % y;

            Console.WriteLine(add);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);
            Console.WriteLine(substract);
            Console.WriteLine(modulus);

            int number = 5;
            // number = number + 1
            Console.WriteLine("Post-Increment: " + number++);
            number = 5;
            Console.WriteLine("Pre-Increment: " + ++number);
            number = 5;

            //number = number - 1
            Console.WriteLine("Post-Increment: " + number--);
            number = 5;
            Console.WriteLine("Pre-Increment: " + --number);
        }

        public static void Assignment()
        {
            // Cascade
            int x, y, z;
            x = y = z = 5;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            x += 2; // x = x + 2
            Console.WriteLine(x);
        }

        public static void Logical()
        {
            int x = 3;
            int y = 5;

            // Logical AND
            // True & True > True
            // True & False > False
            // False & True > False
            // False & False > False
            bool condition = (x == 3) && (y == 5);
            Console.WriteLine(condition);

            // Logical OR
            // True || True > True
            // True || False > True
            // False || True > True
            // False || False > False
            condition = x == y || true;
            Console.WriteLine(condition);

            // Logical Negation
            // True > False
            // False > True
            condition = !(x == y);
            Console.WriteLine(condition);
        }
    }
}

namespace SeriesA
{
    public class CNumeric
    {
        // byte > short > int > long > float > double
        static byte byteType = 5;
        static short shortType = 5;
        static int intType = 5;
        static long longType = 5;
        static float floatType = 5;
        static double doubleType = 5;

        public static void toDouble()
        {
            double toDouble;
            toDouble = byteType;
            toDouble = shortType;
            toDouble = intType;
            toDouble = longType;
            toDouble = floatType;
        }

        public static void toFloat()
        {
            float toFloat;
            toFloat = byteType;
            toFloat = shortType;
            toFloat = intType;
            toFloat = longType;
            //toFloat = doubleType:
        }

        public static void toLong()
        {
            long toLong;
            toLong = byteType;
            toLong = shortType;
            toLong = intType;
            //toLong = floatType;
            //toLong = doubleType;
        }

        public static void toInt()
        {
            int toInt;
            toInt = byteType;
            toInt = shortType;
            //toInt = longType;
            //toInt = floatType;
            //toInt = doubleType;
        }

        public static void toShort()
        {
            short toShort;
            toShort = byteType;
            //toShort = intType;
            //toShort = longType;
            //toShort = floatType;
            //toShort = doubleType;
        }

        public static void toByte()
        {
            byte toByte;
            //toByte = shortType;
            //toByte = intType;
            //toByte = longType;
            //toByte = floatType;
            //toByte = doubleType;
        }

        public static void Convertion()
        {
            long l1 = 500L;
            long l2 = 500;

            // int i1 = l1
            int i2 = (int)l1; // Convert with Cast
            int i3 = Convert.ToInt32(11); // Convert with Parsing


            Console.WriteLine(i2);
            Console.WriteLine(i3);
        }

    }
}

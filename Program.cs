internal class Program
{
    private static void Main(string[] args)
    {
        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                Console.Write("Ingrese primer numero: ");
                int num_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese segundo numero: ");
                int num_2 = Convert.ToInt32(Console.ReadLine());
                // otro ejemplo 2620 y 2924, 1184 y 1210, 5020 y 5564, 6232 y 6368
                if (NumFriend(num_1) == num_2 && NumFriend(num_2) == num_1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Los numeros {num_1} y {num_2} son numeros amistosos");
                    Console.WriteLine($"(っ＾▿＾)۶🍸🌟🍺٩(˘◡˘ )\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"Los numeros {num_1} y {num_2} NO son numeros amistosos");
                    Console.WriteLine($"(ง︡'-'︠)ง(ง︡'-'︠)ง(ง︡'-'︠)ง");
                }
                run = false;
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Error: {e.StackTrace}\n\nMensaje: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"El numero de entrada o salida es demasiado grande \n Mensaje: {e.Message}");
            }
            Console.ReadKey();

        }
        Console.ForegroundColor = ConsoleColor.White;



        static int NumFriend(int num)
        {
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
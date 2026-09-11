namespace CS_Triangle_Drawer
{
    internal class Program
    {
        static string RepeatString(string text, int count)
        {
            return string.Concat(Enumerable.Repeat(text, count));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input height:");
            int height = Convert.ToInt32(Console.ReadLine());

            string start_spacing = RepeatString(" ", height);
            string spacing = RepeatString(" ", 1);

            for (int i = 1; i <= height; i++)
            {
                if (i < 10 && height > 10) { spacing = "  "; } //default
                else if (i < 10) { spacing = " "; }  // for big triangle
                else { spacing = " "; } // for big triangle
                start_spacing = RepeatString(" ", height - i);
                Console.WriteLine($"{start_spacing}{RepeatString($"{i}{spacing}", i)}");
            }
        }
    }
}
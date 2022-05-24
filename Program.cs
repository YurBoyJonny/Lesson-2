using System;

namespace Lesson_2
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Lesson2())
                game.Run();
        }
    }
}

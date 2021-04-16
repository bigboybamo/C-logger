using System;

namespace Logger2
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            logger.Log("Bamiji bamo");
            logger.Log("works");
        }
    }
}

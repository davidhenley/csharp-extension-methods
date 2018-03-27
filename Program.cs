using System;

namespace ExtensionMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                string post = "This is supposed to be a very long blog post blah blah blah.";

                // You cannot inherit from string because it is sealed
                // You must create an extension on that string class

                var shortenedPost = post.Shorten(5);

                Console.WriteLine(shortenedPost);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using ConsoleApp4.Musiqi;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Music music = new Music("Breed","Nirvana",300);
            Music music1 = new Music("Ali","Mahammadov",100);
            
            User user = new User ("Ali","567");
            string test = "efref23_.";
            test.CheckUsername();
   
        }
    }
}
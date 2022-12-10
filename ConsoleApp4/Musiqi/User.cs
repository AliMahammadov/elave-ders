using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Musiqi
{
    internal class User
    {
        public static List<User> _allUser=new List<User>();

        private static int _count = 0;
        public int Id { get;}

        public string Username { get; set; }
        public string Password { get; set; }

        public List<Music> Playlist { get; set; }

        public User(string username, string password)
        {
            Username= username;
            Password= password;
            Id= _count++;
            Playlist = new List<Music>();

        }
        public void AddMusic(Music music)
        {
            //for (int i = 0; i < Playlist.Count; i++)
            //{
            //    if (Playlist[i].Id==music.Id)
            //    {
            //        Console.WriteLine("this music already exists");
            //        return;
            //    }    
            //}
            
            Music existed = Playlist.Find(m=>m.Id ==music.Id);
            if (existed != null)
            {
                Playlist.Add(music);
                Console.WriteLine("this music already exists");
                return;

                   
            }
            Console.WriteLine("This music already exists");



        }
        public static void RegisterUser()
        {
            Console.WriteLine("plese enter username");
            string username = Console.ReadLine().Trim().ToLower();
            if (!username.CheckUsername())
            {
                Console.WriteLine("uytyghujioiu 6, ve 12 simvol");
            }
        }
    }
}

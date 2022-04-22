using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAWC
{
    public class Game
    {
        private Player _player;

        public Game()
        {
            _player = new Player("John Doe");

            World.Instance.Create();
            _player.EnterRoom(World.Instance.Rooms.Where(r => r.Start == true).SingleOrDefault());

        }
        public void Welcome()
        {
            Console.WriteLine("The game is initializing..");
            Console.WriteLine($"You're name is { _player.Name}");
            Console.WriteLine("You'll have to kill all the creatures in this house");
            Console.WriteLine($"Healthpoints : {_player.HealthPoints}");
            Console.WriteLine($"You're in the: {_player.Room.Name} ");
            Console.WriteLine($"You have your bare hands");
            Console.WriteLine("Use command 'help' to see lists of commands");

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFtbGame.Models;

namespace WPFtbGame.Models
{
    public class Player : Character
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                ID = 1,
                DogName = "Alfred",
                Age = "12",
                typeOfDog = Character.TypeOfDog.Doxin,
                Health = 100,
                Lives = 1,
                LocationId = 0

            };
        }
        
    }
}

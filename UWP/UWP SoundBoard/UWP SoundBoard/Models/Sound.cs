using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_SoundBoard.Models
{
    enum AudioType
    {
        ANIMALS,
        CARTOONS,
        TAUNTS,
        WARNINGS
    }

    internal class Sound
    {
        internal AudioType AudType { get; set; }
        internal string AudioDescription { get; set; }
        internal string AudioSource { get; set; }
        internal string ImageSource { get; set; }

        internal static List<Sound> GetSounds()
        {
            List<Sound> sounds = new List<Sound>();

            sounds.Add(new Sound() { AudType=AudioType.ANIMALS , AudioDescription="Cat" , AudioSource="/Assets/Audio/Animals/Cat.wav" , ImageSource="Assets/Images/Animals/Cat.png" });
            sounds.Add(new Sound() { AudType=AudioType.ANIMALS , AudioDescription="Cow" , AudioSource="/Assets/Audio/Animals/Cow.wav" , ImageSource="Assets/Images/Animals/Cow.png" });
            sounds.Add(new Sound() { AudType=AudioType.CARTOONS , AudioDescription="Gun" , AudioSource="/Assets/Audio/Cartoons/Gun.wav" , ImageSource= "Assets/Images/Cartoons/Gun.png" });
            sounds.Add(new Sound() { AudType=AudioType.CARTOONS , AudioDescription="Spring" , AudioSource="/Assets/Audio/Cartoons/Spring.wav" , ImageSource= "Assets/Images/Cartoons/Spring.png" });
            sounds.Add(new Sound() { AudType=AudioType.TAUNTS ,AudioDescription="Clock" , AudioSource="/Assets/Audio/Taunts/Clock.wav" , ImageSource= "Assets/Images/Taunts/Clock.png" });
            sounds.Add(new Sound() { AudType=AudioType.TAUNTS ,AudioDescription="LOL" , AudioSource="/Assets/Audio/Taunts/LOL.wav" , ImageSource= "Assets/Images/Taunts/LOL.png" });
            sounds.Add(new Sound() { AudType=AudioType.WARNINGS , AudioDescription="Ship" , AudioSource="/Assets/Audio/Warnings/Ship.wav" , ImageSource= "Assets/Images/Warnings/Ship.png" });
            sounds.Add(new Sound() { AudType=AudioType.WARNINGS , AudioDescription="Siren" , AudioSource="/Assets/Audio/Warnings/Siren.wav" , ImageSource= "Assets/Images/Warnings/Siren.png" });

            return sounds;
        }
    }
}

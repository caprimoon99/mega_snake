using System;
using System.Media;

namespace Snake
{
    class Sound
    {
        public static void PlayMusic(string filepath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filepath;
            musicPlayer.Play();
        }

        static void PlayGameMusic()
        {
            if (Gameloop == 0
        }
    }
}

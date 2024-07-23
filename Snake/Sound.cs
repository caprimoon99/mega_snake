using System;
using System.Media;
using System.Windows.Media;
using System.IO;

namespace Snake
{
    public static class Sound
    {
        private static MediaPlayer backgroundMusicPlayer = null;

        public static void PlayBackgroundMusic(string filepath)
        {
            if (backgroundMusicPlayer == null)
            {
                backgroundMusicPlayer = new MediaPlayer();
                backgroundMusicPlayer.MediaEnded += (sender, e) =>
                {
                    backgroundMusicPlayer.Position = TimeSpan.Zero;
                    backgroundMusicPlayer.Play();
                };
            }

            backgroundMusicPlayer.Open(new Uri(filepath, UriKind.Relative));
            backgroundMusicPlayer.Play();
        }

        public static void StopBackgroundMusic()
        {
            if (backgroundMusicPlayer != null)
            {
                backgroundMusicPlayer.Stop();
                backgroundMusicPlayer.Close();
                backgroundMusicPlayer = null;
            }
        }

        public static void PlaySoundEffect(string filepath)
        {
            MediaPlayer soundEffectPlayer = new MediaPlayer();
            soundEffectPlayer.Open(new Uri(filepath, UriKind.Relative));
            soundEffectPlayer.Play();
        }


        public static string GetAssetPath(string filename)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", filename);
        }

    }
}

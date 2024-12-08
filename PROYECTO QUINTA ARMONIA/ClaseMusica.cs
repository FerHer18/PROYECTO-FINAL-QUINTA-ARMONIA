using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PROYECTO_QUINTA_ARMONIA
{
    public class ClaseMusica
    {
        private static WMPLib.WindowsMediaPlayer player;
        private static bool reproduciendo = false;

        public static void Load(string file)
        {
            if (player == null)
            {
                player = new WMPLib.WindowsMediaPlayer();

            }
            player.URL = file;
            player.settings.setMode("loop", true);
        }

        public static void Play()
        {
            if (player != null && !reproduciendo)
            {
                player.controls.play();
                reproduciendo = true;
            }
        }

        // Método para pausar (parar la música)
        public static void Pause()
        {
            if (player != null && reproduciendo)
            {
                player.controls.pause();
                reproduciendo = false;
            }
        }

        // Método para obtener el estado actual
        public static bool IsPlaying()
        {
            return reproduciendo;
        }
    }
}

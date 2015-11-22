using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Media;
using System.Windows.Forms;

namespace ChatClient
{
    static class OWChatSoundPlayer
    {
        static SoundPlayer buzzPlayer, signInPlayer, signOutPlayer, msgPlayer;
        static bool doneLoading = false;
        static String appPath = "";

        public static void loadSoundResources()
        {
            try
            {
                appPath = Application.StartupPath;
                
                buzzPlayer = new SoundPlayer(appPath+ "\\sounds\\beep.wav");
                buzzPlayer.LoadAsync();

                signInPlayer = new SoundPlayer(appPath + "\\sounds\\online.wav");
                signInPlayer.LoadAsync();

                signOutPlayer = new SoundPlayer(appPath + "\\sounds\\offline.wav");
                signOutPlayer.LoadAsync();

                doneLoading = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading sounds : " + ex.Message, "ow-chat Sound System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        public static void playBuzzSound()
        {
            if (doneLoading)
            {
                buzzPlayer.Play();
            }
        }

        public static void playSignOutSound()
        {
            if (doneLoading)
            {
                signOutPlayer.Play();
            }
        }

        public static void playSignInSound()
        {
            if (doneLoading)
            {
                signInPlayer.Play();
            }
        }
    }
}

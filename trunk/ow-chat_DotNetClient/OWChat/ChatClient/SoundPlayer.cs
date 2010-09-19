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

        public static void loadSoundResources()
        {
            try
            {
                buzzPlayer = new SoundPlayer("c:\\Windows\\Media\\chimes.wav");
                buzzPlayer.LoadAsync();
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
    }
}

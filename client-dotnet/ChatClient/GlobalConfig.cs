using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatClient
{
    static class GlobalConfig
    {
        //Name of the current user of the chat client
        private static String displayName;
        private static OWChatService.OWChatService chatService;
        private static String sessionKey;
        private static bool userSignedIn = false;

        public static bool UserSignedIn
        {
            get { return userSignedIn; }
            set { userSignedIn = value; }
        }


        public static frmMainWindow mainWindow; 

        public static String SessionKey
        {
            get { return GlobalConfig.sessionKey; }
            set { GlobalConfig.sessionKey = value; }
        }

        public static OWChatService.OWChatService ChatService
        {
            get 
            {
                if (chatService == null)
                    chatService = new ChatClient.OWChatService.OWChatService();
                return GlobalConfig.chatService; 
            }
            //set { GlobalConfig.chatService = value; }
        }

        public static String DisplayName
        {
            get { return GlobalConfig.displayName; }
            set { GlobalConfig.displayName = value; }
        }

        static GlobalConfig()
        {

        }

        public static void showErrorMessage(String message)
        {
            System.Windows.Forms.MessageBox.Show(message, "ow-chat", 
                System.Windows.Forms.MessageBoxButtons.OK, 
                System.Windows.Forms.MessageBoxIcon.Error);
        }



    }
}

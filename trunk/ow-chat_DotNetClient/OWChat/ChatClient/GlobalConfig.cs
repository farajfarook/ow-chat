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

        public static String DisplayName
        {
            get { return GlobalConfig.displayName; }
            set { GlobalConfig.displayName = value; }
        }

        static GlobalConfig()
        {

        }




    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChatClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //[MTAThread]
        static void Main()
        {
            //OWChatServiceReference chat = new OWChatServiceReference();
            //CalculatorServiceClient proxy = new CalculatorServiceClient();

            //int result = proxy.Add(2, 3);

            //Console.WriteLine("Calculator Service returned: " + result.ToString());
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.mainWindow = new frmMainWindow();
            Application.Run(GlobalConfig.mainWindow);
            //Application.Run(new signInFrm());
        }
    }
}

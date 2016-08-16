/*
 * Created by Ranorex
 * User: Seema Rao
 * Date: 02-08-2016
 * Time: 09:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.IO;
//using ImapX;



using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace imap1
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("718B2208-911C-4270-BBD4-62B6F64DE34C", ModuleType.UserCode, 1)]
    public class UserCodeModule1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule1()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            Imap imap = new Imap();
          
                imap.Connect("nat01.tigers.dubber.net");   // or ConnectSSL for SSL 
                imap.Login("dubber@qa.dubber.net", "D2015ubber1");
                Console.WriteLine("success");
                imap.SelectInbox();
                List<long> uids = imap.Search(Flag.Unseen);
                imap.close();
            
            
            
            
        }
    }
}

﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace browser5
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("ba0f7233-c945-46ec-aab0-b28c4208220b", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the browser5Repository repository.
        /// </summary>
        public static browser5Repository repo = browser5Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 50;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://tigers.dubber.net/login' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("https://tigers.dubber.net/login", "Chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dubber.UserEmail' at 102;17.", repo.Dubber.UserEmailInfo, new RecordItemIndex(2));
            repo.Dubber.UserEmail.Click("102;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'qa{RShiftKey down}+{RShiftKey up}4{RShiftKey down}@{RShiftKey up}dubber.net' with focus on 'Dubber.UserEmail'.", repo.Dubber.UserEmailInfo, new RecordItemIndex(3));
            repo.Dubber.UserEmail.PressKeys("qa{RShiftKey down}+{RShiftKey up}4{RShiftKey down}@{RShiftKey up}dubber.net", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dubber.UserEmail' at 102;17.", repo.Dubber.UserEmailInfo, new RecordItemIndex(4));
            repo.Dubber.UserEmail.Click("102;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dubber.UserEmail' at 145;20.", repo.Dubber.UserEmailInfo, new RecordItemIndex(5));
            repo.Dubber.UserEmail.Click("145;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'Dubber.UserEmail'.", repo.Dubber.UserEmailInfo, new RecordItemIndex(6));
            repo.Dubber.UserEmail.PressKeys("{Return}", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dubber.UserPassword' at 125;21.", repo.Dubber.UserPasswordInfo, new RecordItemIndex(7));
            repo.Dubber.UserPassword.Click("125;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'P@ssword1' with focus on 'Dubber.UserPassword'.", repo.Dubber.UserPasswordInfo, new RecordItemIndex(8));
            repo.Dubber.UserPassword.PressKeys("P@ssword1", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dubber.SubmitButton' at 15;14.", repo.Dubber.SubmitButtonInfo, new RecordItemIndex(9));
            repo.Dubber.SubmitButton.Click("15;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Dubber' at 1355;159.", repo.Dubber.SelfInfo, new RecordItemIndex(11));
            repo.Dubber.Self.MoveTo("1355;159");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'Dubber' at 1365;539.", repo.Dubber.SelfInfo, new RecordItemIndex(12));
            repo.Dubber.Self.MoveTo("1365;539");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dubber.IconCogIconWhite' at 11;7.", repo.Dubber.IconCogIconWhiteInfo, new RecordItemIndex(13));
            repo.Dubber.IconCogIconWhite.Click("11;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dubber.DropDownLogout' at 72;3.", repo.Dubber.DropDownLogoutInfo, new RecordItemIndex(14));
            repo.Dubber.DropDownLogout.Click("72;3");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

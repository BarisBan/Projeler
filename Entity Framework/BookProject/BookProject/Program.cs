﻿using BookProject.Views.Admin.AppUserView;
using BookProject.Views.Admin.BookView;
using BookProject.Views.Admin.CategoryView;
using BookProject.Views.Admin.MasterView;
using BookProject.Views.Member.MemberView;
using BookProject.Views.Shared.LoginView;
using BookProject.Views.Shared.MainView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CLINICA
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
            //Application.Run(new frmLogin());
            Application.Run(new frmPrincipal());
            //Application.Run(new frmAgendamento());
        }
    }
}

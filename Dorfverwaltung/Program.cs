﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorfverwaltung
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

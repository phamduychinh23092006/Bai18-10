using System;
using System.Windows.Forms;
using BookManagementSystem.Forms;

namespace BookManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBookManager());
        }
    }
}
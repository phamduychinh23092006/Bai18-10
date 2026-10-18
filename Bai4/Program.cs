using System;
using System.Windows.Forms;
using RevenueAnalytics;

namespace HospitalMDI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmRevenueAnalytics());
        }
    }
}
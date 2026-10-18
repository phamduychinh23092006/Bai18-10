using System;
using System.Windows.Forms;
using CryptoStockTicker;

namespace HospitalMDI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmCryptoStockTicker());
        }
    }
}
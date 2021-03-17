using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CesarovaSifra
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int key = 7;
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public MainWindow()
        {

            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            string msgIn = tbMsgIn.Text;
            string msgOut = null;
            foreach (char item in msgIn.ToUpper())
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                    if (alpha[i] == item)
                    {
                        int encryptedPosition = i + key;
                        if (encryptedPosition > alpha.Length)
                        {
                            encryptedPosition -= 26;
                            msgOut += alpha[encryptedPosition];
                        }
                        else
                        {
                            msgOut += alpha[encryptedPosition];
                        }
                    }
                } 
    
            }
            tbMsgOut.Text = msgOut;

        }

        private void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            string msgIn = tbMsgIn.Text;
            string msgOut = null;
            foreach (char item in msgIn.ToUpper())
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                    if (alpha[i] == item)
                    {
                        int encryptedPosition = i - key;
                        if (encryptedPosition > alpha.Length)
                        {
                            encryptedPosition -= 26;
                            msgOut += alpha[encryptedPosition];
                        }
                        else if (encryptedPosition < 0)
                        {
                            encryptedPosition += 26;
                            msgOut += alpha[encryptedPosition];

                        }
                        {
                            msgOut += alpha[encryptedPosition];
                        }
                    }
                }
            }

            tbMsgOut.Text = msgOut;

        }
    }
}

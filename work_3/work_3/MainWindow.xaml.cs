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

namespace work_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string strInput;
        double douOutput;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtMG.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtG.Text = string.Format("{0:0.##########}", _value / 1000);
            if (_kind != 2)
                txtKG.Text = string.Format("{0:0.##########}", _value / 1000000);
            if (_kind != 3)
                txtT.Text = string.Format("{0:0.##########}", _value / 1000000000);
            if (_kind != 4)
                txtOzT.Text = string.Format("{0:0.##########}", _value / 28349.52);
            if (_kind != 5)
                txtLB.Text = string.Format("{0:0.##########}", _value / 453592.33);
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtMG.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else 
            {
                txtInfo.Text = "請輸入數字";
                txtMG.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtMG.Text = "";
            txtG.Text = "";
            txtKG.Text = "";
            txtT.Text = "";
            txtOzT.Text = "";
            txtLB.Text = "";
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtG.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 1000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtG.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKG.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 1000000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKG.Text = "";
            }
        }

        private void txtIN_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtT.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 1000000000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtT.Text = "";
            }
        }

        private void txtFT_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtOzT.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 28349.52);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtOzT.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtLB.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 453592.33);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtLB.Text = "";
            }
        }
    }
}

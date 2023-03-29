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

namespace WeightConvert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數
        public MainWindow()
        {
            InitializeComponent();
        }
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtMG.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtGRAM.Text = string.Format("{0:0.##########}", _value / 1000);
            if (_kind != 2)
                txtKG.Text = string.Format("{0:0.##########}", _value / 1000000);
            if (_kind != 3)
                txtMT.Text = string.Format("{0:0.##########}", _value / 1000000000);
            if (_kind != 4)
                txtOUNCE.Text = string.Format("{0:0.##########}", _value / 28349.5231);
            if (_kind != 5)
                txtPOUND.Text = string.Format("{0:0.##########}", _value / 453592.37);
        }

        private void txtMG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtMG.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtMG.Text = "";
            }
        }
        private void txtGRAM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKG.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput * 1000);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtGRAM.Text = "";
            }
        }
        private void txtKG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKG.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput * 1000);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtKG.Text = "";
            }
        }
        private void txtMT_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtMT.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput * 1000000);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtMT.Text = "";
            }
        }
        private void txtOUNCE_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtOUNCE.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput * 1000000);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtOUNCE.Text = "";
            }
        }
        private void txtPUOND_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtPOUND.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput * 1000000);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtPOUND.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtMG.Text = "";
            txtMT.Text = "";
            txtKG.Text = "";
            txtOUNCE.Text = "";
            txtPOUND.Text = "";
            txtGRAM.Text = "";
        }
    }
}

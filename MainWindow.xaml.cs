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
using Eng_Prog.Windows;
using Eng_Prog.Models;

namespace Eng_Prog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB_Cont db = new DB_Cont();
                var a = db.users.Where(x => x.Password == txtpassword.Password && x.UserName == txtusername.Text).ToList();
                if (a.Count > 0)
                {
                    Main mx = new Main();
                    this.Close();
                    mx.ShowDialog();

                }
                else
                {
                    MessageBox.Show("يوجد خطأ أسم المستخدم أو كلمة المرور");
                    return;
                }
            }
            catch
            {

                MessageBox.Show("حدث خطأ أثناء الإتصال بقاعدةالبيانات");
            }
        }
    }
}

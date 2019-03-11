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
using System.Windows.Shapes;

namespace Diary_Of_Information
{
    /// <summary>
    /// Interaction logic for Add_friend.xaml
    /// </summary>
    public partial class Add_friend : Window
    {
        public Add_friend()
        {
            InitializeComponent();
        }

        private void home_click(object sender, RoutedEventArgs e)
        {
            Home hm = new Home();
            {
                hm.Show();
                this.Close();
            }
        }

        private void submit_btn_click(object sender, RoutedEventArgs e)
        {

        }
    }
}

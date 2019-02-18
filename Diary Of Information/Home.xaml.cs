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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void log_out_click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            {
                mw.Show();
                this.Close();
            }
        }

        private void add_friends_click(object sender, RoutedEventArgs e)
        {

            Add_friend af = new Add_friend();
            {
                af.Show();
                this.Close();
            }
        }
    }
}

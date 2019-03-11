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
using System.Data;
using System.Data.SqlClient;

namespace Diary_Of_Information
{
    /// <summary>
    /// Interaction logic for Friends_Inform.xaml
    /// </summary>
    public partial class Friends_Inform : Window
    {
        public Friends_Inform()
        {
            InitializeComponent();
        }

        private void home_btn_click(object sender, RoutedEventArgs e)
        {
            Home hm = new Home();
            {
                hm.Show();
                this.Close();
            }
        }

        private void txt_search_focus(object sender, RoutedEventArgs e)
        {
            txt_search.Text = "";
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=ARTHI\ARTHISQL;Initial Catalog=diary;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from information where phone = '" + txt_search.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();


            if (read.Read())
            {

                txt_details.Text = "name: " + read[0].ToString();
                txt_details.Text += "\nphone: " + read[1].ToString();
                txt_details.Text += "\naddress: " + read[2].ToString();
                txt_details.Text += "\ndob: " + read[3].ToString();
                txt_details.Text += "\ngender: " + read[4].ToString();
            }
            else
            {
                MessageBox.Show("This number does not exit");
            }
            sqlcon.Close();

            sqlcon.Close();
        }
    }
}

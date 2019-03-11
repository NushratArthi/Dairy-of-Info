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
            string name, address, dob, gender;
            int phone;
            name = txt_name.Text;
            phone = int.Parse(txt_phone.Text);
            address = txt_address.Text;
            dob = date_dob.SelectedDate.Value.ToShortDateString();
            if (radio_male.IsChecked.Value == true)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }



            string connectionstring = @"Data Source=ARTHI\ARTHISQL;Initial Catalog=diary;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into information(name,phone,address,dob,gender) values(@a,@b,@c,@d,@e)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@b", SqlDbType.Int).Value = phone;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@d", SqlDbType.Date).Value = dob;
            cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = gender;

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Save");
            sqlcon.Close();

        }

        private void reset_btn_click(object sender, RoutedEventArgs e)
        {
            clear();
        }
        void clear()
        {
            txt_name.Clear();
            txt_phone.Clear();
            txt_address.Clear();
        }
    }
}

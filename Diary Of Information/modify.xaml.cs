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
    /// Interaction logic for modify.xaml
    /// </summary>
    public partial class modify : Window
    {
        public modify()
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


        private void update_btn_click(object sender, RoutedEventArgs e)
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



            string connectionstring = @"Data Source=ARTHI\ARTHISQL;Initial Catalog=diary;Integrated Security=True ";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "update information set name=@a,phone=@b,address=@c  where phone='" + txt_phone.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@a", SqlDbType.VarChar).Value = txt_name.Text;
            sqlcmd.Parameters.Add("@b", SqlDbType.Int).Value = txt_phone.Text;
            sqlcmd.Parameters.Add("@c", SqlDbType.VarChar).Value = txt_address.Text;

            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();

            if (rows == 1)
                MessageBox.Show("Information Has Updated.");
        }


        private void search_btn_click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=ARTHI\ARTHISQL;Initial Catalog=diary;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from information WHERE phone='" + txt_search.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();


            if (read.Read())
            {

                txt_name.Text = read.GetValue(0).ToString();
                txt_phone.Text = read.GetValue(1).ToString();
                txt_address.Text = read.GetValue(2).ToString();
                date_dob.Text = read.GetValue(3).ToString();
            }
            else
            {
                MessageBox.Show("This number does not exit");
            }

            sqlcon.Close();
        }

        private void load_table_click(object sender, RoutedEventArgs e)
        {
            string con = @"Data Source=ARTHI\ARTHISQL;Initial Catalog=diary;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();

            string sqlquery = "Select name,phone,address,dob,gender from information";
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlcon);

            SqlDataAdapter data_adapter = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable("information");
            data_adapter.Fill(dt);
            datagrid1.ItemsSource = dt.DefaultView;
            data_adapter.Update(dt);
            sqlcon.Close();
        }
    }
}
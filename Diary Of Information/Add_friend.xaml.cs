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
            string connectionstring = @"Data Source=ARTHI\ARTHISQL;Initial Catalog=diary;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into table_name(column_names...) values(@a,@b,@c....)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@b", SqlDbType.Date).Value = datepicker_variable_name.SelectedDate.Value.ToShortDateString();
            cmd.Parameters.Add("@c", SqlDbType.Int).Value = amount;

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Save");
            sqlcon.Close();

        }
    }
}

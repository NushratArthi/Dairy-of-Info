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
    /// Interaction logic for modify.xaml
    /// </summary>
    public partial class modify : Window
    {
        public modify()
        {
            InitializeComponent();
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
        }
    }
}

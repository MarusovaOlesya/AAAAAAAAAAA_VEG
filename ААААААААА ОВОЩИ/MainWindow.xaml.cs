using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace ААААААААА_ОВОЩИ
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection BD;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                BD = new SqlConnection(@"Data source =(localdb)\MSSQLLocalDB; Initial Catalog = OVIHIiFRUKTI;  Integrated Security=SSPI;");
                BD.Open();
                Text.Text = "БД подключена";
            }
            catch
            {
                Text.Text = "eror";
            }
        }

        private void OffClick(object sender, RoutedEventArgs e)
        {
            try
            {
                BD.Close();
                Text.Text = "БД отключена";
            }
            catch
            {
                Text.Text = "eror";
            }
            
        }

        private void VceCkick(object sender, RoutedEventArgs e)
        {
            string MySelect = @"SELECT * FROM Salat";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void NameClick(object sender, RoutedEventArgs e)
        {
            string MySelect = @"SELECT Name FROM Salat";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void ColorClick(object sender, RoutedEventArgs e)
        {
            string MySelect = @"SELECT Color FROM Salat";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void MaxColClick(object sender, RoutedEventArgs e)
        {
            string MySelect = @"SELECT MAX(Calorii) FROM Salat";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void MinColClick(object sender, RoutedEventArgs e)
        {
            string MySelect = @"SELECT MIN(Calorii) FROM Salat";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void CredColClick(object sender, RoutedEventArgs e)
        {
            string MySelect = @"SELECT AVG(Calorii) FROM Salat";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void ColOvClick(object sender, RoutedEventArgs e)
        {
            string MySelect = @"select COUNT(*) from Salat where Tip='veg';";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void ColFruClick(object sender, RoutedEventArgs e)
        {
            string MySelect = @"select COUNT(*) from Salat where Tip='fru';";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void OvFruZadCvetClick(object sender, RoutedEventArgs e)
        {
            string MySelect = @"select Count(*) from Salat where Color='"+ZADCVET.Text+"';";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void KagCvet(object sender, RoutedEventArgs e)
        {
            string MySelect = @"select Color ,COUNT(*) from Salat Group by Color;";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void NegeClick(object sender, RoutedEventArgs e)
        {
            string MySelect = @"select Count(*) from Salat where Calor<'" + Nige + "';";
            SqlCommand command = new SqlCommand(MySelect, BD);

            SqlDataReader sqlDataReader = command.ExecuteReader();


            Vivod.Text = "";

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";
            }
            sqlDataReader.Close();
        }
    }
}

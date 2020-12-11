using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1_DB_DM
{
    public partial class Group_Data : Form
    {
        SqlConnection connect = new SqlConnection (@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\Documents\cyberdata.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command;
        SqlDataAdapter adapter, adapter2;
        int Id = 0;

        private void Lisa_Click(object sender, EventArgs e)
        {
            if (Lisa.Text != "" && Muuda.Text != "" && Kustuta.Text != "" && comboBox1.SelectedItem != null)
            {
                try
                {
                    command = new SqlCommand("INSERT INTO cyberdata(Lisa,Muuda,Kustuta,) VALUES(@lisa,@muuda,@kustuta)", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@lisa", Lisa.Text);
                    command.Parameters.AddWithValue("@muuda", Muuda.Text);
                    command.Parameters.AddWithValue("@kustuta", Kustuta.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Viga lisamisega");
                }
            }
            else
            {
                MessageBox.Show("Viga else");
            }
        }


        public Group_Data()
        {
            InitializeComponent();
        }
    }
}

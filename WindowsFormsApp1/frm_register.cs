using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.Show();
            this.Hide();
        }
        
        private void btn_continuar_Click(object sender, EventArgs e)
        {
            string name, user, password;

            name = txt_Nombre.Text;
            user = txt_usu.Text;
            password = txt_pass.Text;


            //validacion ----------------------------
            if (name == "" ||user == "" || password == "" )
            {
                MessageBox.Show("Ningun campo puede estar vacio");
            }
            else
            {
                try 
                {
                    SQLiteConnection conexion_sqlite;
                    SQLiteCommand cmd_sqlite;

                    conexion_sqlite = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");
                    conexion_sqlite.Open();

                    cmd_sqlite = conexion_sqlite.CreateCommand();
                    cmd_sqlite.CommandText = $"INSERT INTO Users (Nombre, usuario, password) VALUES ('{name}','{user}', '{password}')";
                    cmd_sqlite.ExecuteNonQuery();

                    MessageBox.Show("Usuario registrado correctamente");
                    frm_Login frm = new frm_Login();
                    frm.txt_usu.Text = user;
                    frm.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("usuario is not unique"))
                    {
                        MessageBox.Show($"El usuario {user} ya existe");
                        return;
                    }

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

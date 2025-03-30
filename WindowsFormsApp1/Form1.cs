using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace WindowsFormsApp1
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        int tentos = 0;
        bool usrr = false, pswr = false;
        private void btn_continuar_Click(object sender, EventArgs e)
        {
            string user, password;

            user = txt_usu.Text;
            password = txt_pass.Text;


            //validacion ----------------------------
            if (user == "" || password == "" )
            {
                MessageBox.Show("Ningun campo puede estar vacio");
            }
            else if (tentos < 3)
            {
                try
                {
                    //Utilizamos estos tres objetos de SQLite
                    SQLiteConnection conexion_sqlite;
                    SQLiteCommand cmd_sqlite;
                    SQLiteDataReader datareader_sqlite;

                    conexion_sqlite = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");
                    conexion_sqlite.Open();

                    /////creo la tabla -------------------------------------------------------------------
                    //cmd_sqlite = conexion_sqlite.CreateCommand();
                    //cmd_sqlite.CommandText = "CREATE TABLE Users(id integer primary key, Nombre varchar(20), usuario varchar(25), password varchar(25));";
                    //cmd_sqlite.ExecuteNonQuery();


                    ////Insertando datos en la tabla -----------------------------------------------------------
                    //cmd_sqlite = conexion_sqlite.CreateCommand();
                    //cmd_sqlite.CommandText = "INSERT INTO Users VALUES (1,'Juan Jose','Juan123','122')";
                    //cmd_sqlite.ExecuteNonQuery();


                    cmd_sqlite = conexion_sqlite.CreateCommand();
                    cmd_sqlite.ExecuteNonQuery();
                    cmd_sqlite.CommandText = "SELECT usuario, password, Nombre FROM Users";
                    datareader_sqlite = cmd_sqlite.ExecuteReader();

                    while (datareader_sqlite.Read())
                    {
                        if (user == datareader_sqlite.GetString(0) && password == datareader_sqlite.GetString(1))
                        { 
                            usrr = true;
                            pswr = true;
                            frm_Saludo ventana = new frm_Saludo();
                            ventana.lbl_bien.Text = "BIENVENIDO " + datareader_sqlite.GetString(2);
                            ventana.Show();
                        }
                        else
                        {
                            if (user == datareader_sqlite.GetString(0) && password != datareader_sqlite.GetString(1))
                            {
                                usrr = true;
                                MessageBox.Show("Contraseña incorrecta");
                                tentos++;
                            }
                            //if (user != datareader_sqlite.GetString(0))
                            //{
                            //    usrr = false;
                            //}
                        }
                    }

                    if (usrr == false)
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }

                    conexion_sqlite.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error:  " + ex);
                }
            }
            else
            {
                MessageBox.Show("Maximmo de intetos alcanzado");
            }
        }

        private void lbl_FRMregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_register ventana = new frm_register();
            ventana.Show();
            this.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

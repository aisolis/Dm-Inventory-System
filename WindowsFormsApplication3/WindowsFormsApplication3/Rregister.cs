using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    public partial class Rregister : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Swords\\Desktop\\Database\\Database.mdb");
        OleDbCommand cmd = new OleDbCommand();
        public Rregister()
        {
            InitializeComponent();
            Conexion.Open();
        }

        private void lkbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Form frm = new Form1();

            frm.Show();
        }

        private void txtUser_MouseEnter(object sender, EventArgs e)
        {
            if (txtNewUser.Text == "USER")
            {
                txtNewUser.Text = "";
                txtNewUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            if (txtNewUser.Text == "")
            {
                txtNewUser.Text = "USER";
                txtNewUser.ForeColor = Color.DimGray;
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNewUser.Text == "USER")
            {
                txtNewUser.Text = "";
                txtNewUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtNewPass.Text == "PASSWORD")
            {
                txtNewPass.Text = "";
                txtNewPass.ForeColor = Color.Black;
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_MouseLeave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.Text = "PASSWORD";
                txtNewPass.ForeColor = Color.DimGray;
                txtNewPass.UseSystemPasswordChar = false;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNewPass.Text == "PASSWORD")
            {
                txtNewPass.Text = "";
                txtNewPass.ForeColor = Color.Black;
                txtNewPass.UseSystemPasswordChar = true;
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewUser.Text.Length > 0 || txtNewPass.Text.Length > 0 || cmbNewUserType.Text.Length > 0)
            {
                int i = 0;

                cmd.Connection = Conexion;
                cmd.CommandText = "INSERT INTO LoginUsuarios(Usuario, Contraseña, Tipo) Values('" + txtNewUser.Text + "','" + txtNewPass.Text + "', '" + cmbNewUserType.Text + "')";
                i = cmd.ExecuteNonQuery();

                {

                    cmd.Parameters.AddWithValue("@Usuario", txtNewUser);
                    cmd.Parameters.AddWithValue("@Contraseña", txtNewPass);
                    cmd.Parameters.AddWithValue("@Tipo", cmbNewUserType);
                    MessageBox.Show("You're Registered");

                }


            }
            else
            {
                MessageBox.Show("Any of the fields has an unsupported sign or is incomplete"+MessageBoxIcon.Error);
                txtNewUser.Text = "";
                txtNewPass.Text = "";
                cmbNewUserType.Text = "";
                txtNewUser.Focus();
            }
        }
    }
}

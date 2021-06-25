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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_MouseEnter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USER")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USER";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_MouseEnter(object sender, EventArgs e)
        {
            if (txtPass.Text == "PASSWORD")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_MouseLeave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "PASSWORD";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPass.Text == "PASSWORD")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //creacion de un objeto de conexion //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Swords\Desktop\Database\Database.mdb
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Swords\\Desktop\\Database\\Database.mdb");
            //conexion a la database
            conexion.Open();
            //Armamos la query (la consulta a la base de datos ps)
            string Query = "select User,Password,User_Type from Login_Usuarios where User='" + txtUser.Text + "'and Password='" + txtPass.Text + "'and User_Type='" + cmbUserType.Text + "';";
            //Ejecutamos la Query (o la consulta ps eoe)
            OleDbCommand Command = new OleDbCommand(Query, conexion);
            // Declaramos la variable tipo Reader (una variable lectora we)
            OleDbDataReader DataReader;
            //Ejecutamos la Query atravez del Objeto al que llamamos Command
            DataReader = Command.ExecuteReader();
            //Validaremos si el DataReader tiene algun registro
            Boolean ArethereRecords = DataReader.HasRows;
            //Se valida al usuario en el sistema
            if (ArethereRecords)
            {
                MessageBox.Show("Welcome to the J.A.M.I.S.O system, " + txtUser.Text, "authorized user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Cargaremos el Formulario del sistema :V
                Form MainMenuSystem = new Form1();

            }
            else
            {
                // si el usuario se pasa de lanza y no esta en el sistema psss :v messagebox!
                MessageBox.Show("You are not registered in J.A.M.I.S.O, denied access to" + txtUser, " correct data in some field?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //cerrar evento
                return;
            }
            //cerramos la conexion we :v
            conexion.Close();
        }
    }
}


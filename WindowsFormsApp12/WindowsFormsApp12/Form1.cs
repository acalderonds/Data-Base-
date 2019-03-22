using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class frm_cargardatos : Form
    {
        public frm_cargardatos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Busqueda B = new Busqueda();
            B.Show();
            this.Hide();
        }

        private void btn_datosClick(object sender, EventArgs e)
        {
            string conexion = "server=HGDLAPCALDERONA\\SQLEXPRESS ;" +" database=AdventureWorks2014 ; integrated security = true";
            OperacionesDB OPDB = new OperacionesDB(conexion);

            dgv_resul.AutoGenerateColumns = true;
            dgv_resul.DataSource = OPDB.Getinfo();
        }
    }
}

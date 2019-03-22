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
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        List<string> listanew;
        string conexion = "data source=HGDLAPCALDERONA\\SQLEXPRESS;" + "initial catalog=master;integrated security = true;user id=sa";

        private void btn_return_Click(object sender, EventArgs e)
        {
            frm_cargardatos ret = new frm_cargardatos();
            ret.Show();
            this.Close();
        }

        

        private void listb_bd_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nombreDB = listb_bd.SelectedItem.ToString();
            OperacionesDB Opdb = new OperacionesDB(conexion);//crea una conexion 
            //---------------------carga info a Tablas-------------------------
            listanew = Opdb.DatosBDTablas(nombreDB);//pide las tablas de la BD
            listb_tablas.Items.Clear();//limpia
            foreach (string s in listanew)//carga a la lista los datos TABLAS
            {
                listb_tablas.Items.Add(s);
            }
            //------------------Carga info a Views------------------------------------------
            listanew = Opdb.DatosBDViews(nombreDB);//pide las tablas de la BD
            listb_vistas.Items.Clear();//limpia
            foreach (string s in listanew)//carga a la lista los datos TABLAS
            {
                listb_vistas.Items.Add(s);
            }
            //------------------Carga info a Stored procedures----------------------------
            listanew = Opdb.DatosBDSP(nombreDB);//pide las tablas de la BD
            listb_storeprocedure.Items.Clear();//limpia
            foreach (string s in listanew)//carga a la lista los datos TABLAS
            {
                listb_storeprocedure.Items.Add(s);
            }
        }

        private void listb_vistas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            OperacionesDB Opdb = new OperacionesDB(conexion);

            listanew = Opdb.BasesD();
            foreach (string s in listanew)
            {
                listb_bd.Items.Add(s);
            }
        }
    }
}

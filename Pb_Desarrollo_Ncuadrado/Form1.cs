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

namespace Pb_Desarrollo_Ncuadrado
{
    public partial class Form1 : Form
    {
        SqlConnection DbConn = new SqlConnection("Data Source=VDT-TEC-001;Initial Catalog=Contactos;User ID=sa;Password=123456");
        public Form1()
        {
            InitializeComponent();
        }

        //Cadena de Conexion

        private void btnCarga_Click(object sender, EventArgs e)
        {
            SqlCommand ExecJob = new SqlCommand();
            ExecJob.CommandType = CommandType.StoredProcedure;
            ExecJob.CommandText = "msdb.dbo.sp_start_job";
            ExecJob.Parameters.AddWithValue("@job_name", "Run_SSIS");
            ExecJob.Connection = DbConn; //assign the connection to the command.

            using (DbConn)
            {
                DbConn.Open();
                using (ExecJob)
                {
                    ExecJob.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Importe finalizado a base de datos.");
            MessageBox.Show("Para consultar la información digite el nombre del archivo tal cual como se cargo");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTable.Text))
            {
                MessageBox.Show("El recuadro no puede estar vacio, digite el nombre del archivo.");
                txtTable.Focus();
                return;
            }

            string tuTabla = txtTable.Text.Trim();
            SqlCommand cmd = new SqlCommand("Select * from " +tuTabla+"" , DbConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdConsulta.DataSource = dt;
            DbConn.Close();
        }
    }
}

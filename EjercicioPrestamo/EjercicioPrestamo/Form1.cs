using EjercicioPrestamo.Entidades;
using EjercicioPrestamos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPrestamo
{
    public partial class Form1 : Form
    {
        private TipoPrestamoServicio _tipoPrestamoServicio;
        private PrestamoServicio _prestamoServicio;
        private Prestamo _prestamo;

        public Form1()
        {
            InitializeComponent();
            this._tipoPrestamoServicio = new TipoPrestamoServicio();
            this._prestamoServicio = new PrestamoServicio();
            this._prestamo = new Prestamo();
            
        }

        //MÉTODOS
        public void CargarTiposPrestamo(List<TipoPrestamo> tipoPrestamos)
        {
            listTipoPrestamos.DataSource = null;

            listTipoPrestamos.DataSource = tipoPrestamos;

        }

        public void CargarPrestamos(List<Prestamo> prestamos)
        {
            listPrestamos.DataSource = null;
            listPrestamos.DataSource = prestamos;

        }


        //EVENTOS
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTiposPrestamo(_tipoPrestamoServicio.TraerTiposPrestamo());
            CargarPrestamos(_prestamoServicio.TraerPrestamos());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPrestamo tipoPrestamo = (TipoPrestamo)listTipoPrestamos.SelectedItem;

            if (tipoPrestamo != null)
            {
                txtLinea.Enabled =  false;
                txtTNA.Enabled = false;

                txtLinea.Text = tipoPrestamo.Linea.ToString();
                txtTNA.Text = tipoPrestamo.TNA.ToString();
            }
            
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo(txtLinea.Text, double.Parse(txtTNA.Text), 
                int.Parse(txtPlazo.Text), double.Parse(txtMonto.Text));

            if(txtMonto != null && txtPlazo != null)
            {
                txtCuotaCapital.Enabled = false;
                txtCuotaInteres.Enabled = false;
                txtCuotaTotal.Enabled = false;
                
                txtCuotaCapital.Text = prestamo.CuotaCapital.ToString();
                txtCuotaInteres.Text = prestamo.CuotaInteres.ToString();
                txtCuotaTotal.Text = prestamo.CuotaTotal.ToString();
            }
            else
            {
                //Ver para que aparezca el mensaje
                MessageBox.Show("Debe ingresar Monto y Plazo primer.");
            }
             
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo prestamo = new Prestamo(txtLinea.Text, double.Parse(txtTNA.Text),
                int.Parse(txtMonto.Text), double.Parse(txtPlazo.Text));

                _prestamoServicio.AgregarPrestamo(prestamo);

                MessageBox.Show("Prestamo agregado!");

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}

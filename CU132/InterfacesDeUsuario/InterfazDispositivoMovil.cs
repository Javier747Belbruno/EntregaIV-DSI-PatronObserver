using CU132.Interfaces;
using CU132.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU132.InterfacesDeUsuario
{
    public partial class InterfazDispositivoMovil : Form, IObservadorDetallePedido
    {
        public InterfazDispositivoMovil()
        {
            InitializeComponent();
            AcomodarPantalla();
        }

        public void AcomodarPantalla()
        {
            this.StartPosition = 0;
            this.Left = 935;
            this.Top = 40;
            pictureBoxBell.Image = Resources.blackbell2;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void Visualizar(Dictionary<int, int> mapMesaCantidadProd, int sumaTotalProductos)
        {
            foreach (KeyValuePair<int, int> kvp in mapMesaCantidadProd)
                dataGridView1.Rows.Add(kvp.Key, kvp.Value);

            lblNumeroPlatos.Text = sumaTotalProductos.ToString();

            playBell();
        }


        public void playBell()
        {
            pictureBoxBell.Image = Resources.Green_Bell_v2__Sounding;
            SoundPlayer simpleSound = new SoundPlayer(Resources.bell_sound);
            simpleSound.Play();
        }

        
    }
}

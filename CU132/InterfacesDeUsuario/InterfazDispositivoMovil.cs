using CU132.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CU132.InterfacesDeUsuario
{
    public partial class InterfazDispositivoMovil : Form, IObservadorDetallePedido
    {
        public InterfazDispositivoMovil()
        {
            InitializeComponent();
        }

        public void visualizar()
        {
            throw new NotImplementedException();
        }
    }
}

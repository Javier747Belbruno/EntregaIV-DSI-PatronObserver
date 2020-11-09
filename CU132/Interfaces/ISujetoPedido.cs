﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CU132.Interfaces
{
    interface ISujetoPedido
    {
        void Notificar();

        void Quitar(List<IObservadorDetallePedido> observadores);

        void Subscribir(List<IObservadorDetallePedido> observadores);

    }
}

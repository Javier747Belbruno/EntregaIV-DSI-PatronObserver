﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CU132.Interfaces
{
    interface IObservadorDetallePedido
    {
        void Visualizar(Dictionary<int, int> mapMesaCantidadProd, int sumaProductos);
    }
}

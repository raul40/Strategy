﻿using Strategy.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public class ImagenPGStrategy : ISalvadorTipoImagen
    {
        public void GuardarImagen(string _cNombreImagen)
        {
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.pg", _cNombreImagen));
        }
    }
}

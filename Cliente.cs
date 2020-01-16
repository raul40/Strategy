using Strategy.Strategy;
using Strategy.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Cliente
    {
        ISalvadorTipoImagen SalvadorTipoImagen;
        public void Main()
        {
            string cNombreImagen = ObtenerNombreImagen();

            string cOpc = ObtenerTipoImagen(cNombreImagen);

            GuardarImagen(cNombreImagen, cOpc);
            Console.ReadLine();
        }

        private void GuardarImagen(string cNombreImagen, string cOpc)
        {
            SalvadorTipoImagen = ObtenerInstanciaTipoImagen(cOpc);
            SalvadorTipoImagen.GuardarImagen(cNombreImagen);
        }

        private ISalvadorTipoImagen ObtenerInstanciaTipoImagen(string cOpc)
        {
            switch (cOpc)
            {
                case "1":
                    SalvadorTipoImagen = new ImagenPNGStrategy();
                    break;
                case "2":
                    SalvadorTipoImagen = new ImagenGIFStrategy();
                    break;
                case "3":
                    SalvadorTipoImagen = new ImagenJPEGStrategy();
                    break;
                case "4":
                    SalvadorTipoImagen = new ImagenPGStrategy();
                    break;
                case "5":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opcion Incorrecta");
                    Main();
                    break;
            }

            return SalvadorTipoImagen;
        }

        private string ObtenerTipoImagen(string _cNombreImagen)
        {
            Console.WriteLine("Selecciona la extension de la imagen:\n1.- PNG\n2.- GIF\n3.- JPEG\n4.- PG\n5.- Salir");
            return Console.ReadLine();
        }

        private string ObtenerNombreImagen()
        {
            Console.WriteLine("Escriba el nombre de la imagen:");
            return Console.ReadLine();
        }
    }
}

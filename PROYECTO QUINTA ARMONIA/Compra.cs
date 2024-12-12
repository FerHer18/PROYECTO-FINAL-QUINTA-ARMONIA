using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_QUINTA_ARMONIA
{
    public class Compra
    {
        private int cantidad;
        private string name;
        private int codigo;
        private float precio;

        public Compra(int cantidad, string name, int codigo, float precio)
        {
            this.Cantidad = cantidad;
            this.Name = name;
            this.Codigo = codigo;
            this.Precio = precio;

        }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Name { get => name; set => name = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}

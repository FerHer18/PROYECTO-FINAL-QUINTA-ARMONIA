using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_QUINTA_ARMONIA
{
    public class Compra
    {
        private int codigo;
        private string name;
        private float precio;
        private int cantidad; 
        
        public Compra(int codigo, string name, float precio, int cantidad)
        {
            this.Cantidad = cantidad;
            this.Name = name;
            this.Codigo = codigo;
            this.precio = precio;
        }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Name { get => name; set => name = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}

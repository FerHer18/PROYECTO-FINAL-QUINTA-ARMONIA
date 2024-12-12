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

        public Compra(int cantidad, string name, int codigo)
        {
            this.Cantidad = cantidad;
            this.Name = name;
            this.Codigo = codigo;

        }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Name { get => name; set => name = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
}

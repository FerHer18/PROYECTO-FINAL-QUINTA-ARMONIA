using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_QUINTA_ARMONIA
{
    public class ClassProductos
    {
        private int codigo;
        private string nombre = "";
        private string descripcion = "";
        private float precio;
        private int existencias;

        public ClassProductos(int id, string name, string desc, float precio, int existencias)
        {
            this.codigo = id;
            this.nombre = name;
            this.descripcion = desc;
            this.precio = precio;
            this.existencias = existencias;
        }
        public ClassProductos(int id)
        {
            this.codigo = id;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }
    }
}

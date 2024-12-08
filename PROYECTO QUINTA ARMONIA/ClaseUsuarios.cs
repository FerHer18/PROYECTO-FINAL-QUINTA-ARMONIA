using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_QUINTA_ARMONIA
{
    public class ClaseUsuarios
    {
        private int id;
        private string nombre = "";
        private string cuenta = "";
        private string contraseña = "";
        private float monto;

        public ClaseUsuarios(int id, string nombre, string cuenta, string contraseña, float monto)
        {
            Id = id;
            Nombre = nombre;
            Cuenta = cuenta;
            Contraseña = contraseña;
            Monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public float Monto { get => monto; set => monto = value; }
    }
}

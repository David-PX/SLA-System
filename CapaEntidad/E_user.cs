using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class E_user
    {
        private int _ID;
        private string _NOMBRE;
        private string _APELLIDO;
        private string _EMAIL;
        private string _USUARIO;
        private string _CONTRA;
        private string ROLE;
        private string STATE;

        public int ID { get => _ID; set => _ID = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string APELLIDO { get => _APELLIDO; set => _APELLIDO = value; }
        public string EMAIL { get => _EMAIL; set => _EMAIL = value; }
        public string USUARIO { get => _USUARIO; set => _USUARIO = value; }
        public string CONTRA { get => _CONTRA; set => _CONTRA = value; }
        public string ROLE1 { get => ROLE; set => ROLE = value; }
        public string STATE1 { get => STATE; set => STATE = value; }
    }
}

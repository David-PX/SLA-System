using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
namespace CapaNegocios
{
    public class N_user
    {
        D_user data = new D_user();
        public DataTable Login(string user, string password)
        {
            return data.login(user,password);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial01.Services
{
    public class PaisRepositorioEnMemoria: IRepositorioPais
    {
        public List<string> ObtenerTodos()
        {
            List<string> paises;

            paises = new List<string>();
            paises.Add("República Dominicana");
            paises.Add("México");
            paises.Add("Colombia");

            return paises;
        }
    }
}

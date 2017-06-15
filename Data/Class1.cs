using CodingChallenge.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Class1
    {
        public void start()
        {
            var repositorio = new MockRepository().TituloRepository;
            var titulos = repositorio.GetTitulos();
        }
    }
}

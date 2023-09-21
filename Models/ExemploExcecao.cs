using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {
        public void Metdodo1()
        {
            Metdodo2();
        }

        public void Metdodo2()
        {
            Metdodo3();
        }

        public void Metdodo3()
        {
            Metdodo4();
        }

        public void Metdodo4()
        {
            throw new Exception("Ocorreu um exceção.");
        }
    }

}
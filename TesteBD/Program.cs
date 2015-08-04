using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBD
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ContextoBD())
            {
                Universidade uni = new Universidade();
                uni.nome = "Universidade1";
                context.universidades.Add(uni);
                context.SaveChanges();
            }
        }
    }
}

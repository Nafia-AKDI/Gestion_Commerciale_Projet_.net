using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock2.Data_Base
{
    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string PU { get; set; }

        public Article(int id, string nom, string pu)
        {
            Id = id;
            Nom = nom;
            PU = pu;
        }
    }
}

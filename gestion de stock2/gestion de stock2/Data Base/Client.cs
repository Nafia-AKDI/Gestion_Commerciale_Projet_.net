using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock2.Data_Base
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Number { get; set; }

        public string Ville { get; set; }

        public Client(int id, string nom, string number, string ville)
        {
            Id = id;
            Nom = nom;
            Number = number;
            Ville = ville;
        }
    }
}

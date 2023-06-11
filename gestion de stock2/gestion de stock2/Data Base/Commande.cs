using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock2.Data_Base
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime DateCmd { get; set; }
        public int ClientId { get; set; }
        public int ArticleId { get; set; }
        public int Quantite { get; set; }

        public Commande(int id, DateTime dateCmd, int clientId, int articleId, int quantite)
        {
            Id = id;
            DateCmd = dateCmd;
            ClientId = clientId;
            ArticleId = articleId;
            Quantite = quantite;
        }
    }
}

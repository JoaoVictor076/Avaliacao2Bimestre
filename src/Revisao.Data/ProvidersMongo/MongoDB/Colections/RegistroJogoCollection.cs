using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.ProvidersMongo.MongoDB.Colections
{
    [BsonCollection("RegistroJogo")]
    public class RegistroJogoCollection
    {
       

        public int primeiroNumero { get; private set; }
        public int segundoNumero { get; private set; }
        public int terceiroNumero { get; private set; }
        public int quartoNumero { get; private set; }
        public int quintoNumero { get; private set; }
        public int sextoNumero { get; private set; }

    }
}

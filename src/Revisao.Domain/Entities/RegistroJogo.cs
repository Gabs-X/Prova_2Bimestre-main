using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
	public class RegistroJogo
	{

        public int jogo_id { get; private set; }
        public int primeiroNumero { get; private set; }
        public int segundoNumero { get; private set; }
        public int terceiroNumero { get; private set; }
        public int quartoNumero { get; private set; }
        public int quintoNumero { get; private set; }
        public int sextoNumero { get; private set; }


        public RegistroJogo(int primeiroNumero, int segundoNumero, int terceiroNumero, int quartoNumero, int quintoNumero, int sextoNumero)
		{
			this.primeiroNumero = primeiroNumero;
			this.segundoNumero = segundoNumero;
			this.terceiroNumero = terceiroNumero;
			this.quartoNumero = quartoNumero;
			this.quintoNumero = quintoNumero;
			this.sextoNumero = sextoNumero;
		}

		public RegistroJogo(int jogo_id, int primeiroNumero, int segundoNumero, int terceiroNumero, int quartoNumero, int quintoNumero, int sextoNumero)
		{
			this.jogo_id = jogo_id;
			this.primeiroNumero = primeiroNumero;
			this.segundoNumero = segundoNumero;
			this.terceiroNumero = terceiroNumero;
			this.quartoNumero = quartoNumero;
			this.quintoNumero = quintoNumero;
			this.sextoNumero = sextoNumero;
		}



	}
}

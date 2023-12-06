using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
	public interface IJogoService
	{
		public Task RegistrarJogo(JogoViewModel registroJogoViewModel);

		public Task<IEnumerable<RegistroJogoViewModel>> ObterTodosOsJogos();
	}
}

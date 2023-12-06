using Microsoft.EntityFrameworkCore;
using Revisao.Data.EntityFramework;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class RegistroJogoRepository : IRegistroJogoRepository
    {

        private readonly Contexto _contexto;

        public RegistroJogoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        
        public async Task<IEnumerable<RegistroJogo>> ObterTodosOsJogos()
        {
            return await _contexto.RegistroJogo.ToListAsync();
        }

        public async Task RegistrarJogo(RegistroJogo registroJogo)
        {
            try
            {
                await _contexto.RegistroJogo.AddAsync(registroJogo);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir o usuário: {ex.Message}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;

namespace Revisao.Data.Repository
{
    public class RegistroJogoRepository : IRegistroJogoRepository
    {
        private readonly IRegistroJogoRepository _registroJogoRepository;
        private readonly IMapper _mapper;

        public RegistroJogoRepository(IRegistroJogoRepository registroJogoRepository, IMapper mapper)
        {
            _registroJogoRepository = registroJogoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RegistroJogoViewModel>> ObterTodosOsJogos()
        {
            return _mapper.Map<IEnumerable<RegistroJogoViewModel>>(await _registroJogoRepository.ObterTodosOsJogos());

        }

        public async Task RegistrarJogo(RegistroJogoViewModel registroJogoViewModel)
        {
            //Criar reggra de negocio aqui para um jogo valido.

            await _registroJogoRepository.RegistrarJogo(_mapper.Map<RegistroJogo>(registroJogoViewModel));
        }

        public  async Task RegistrarJogo(RegistroJogo registroJogo)
        {
            await _registroJogoRepository.RegistrarJogo(_mapper.Map<RegistroJogo>(registroJogo));
        }

         async Task<IEnumerable<RegistroJogo>> IRegistroJogoRepository.ObterTodosOsJogos()
        {
            return _mapper.Map<IEnumerable<RegistroJogo>>( await _registroJogoRepository.ObterTodosOsJogos());
        }
    }
}

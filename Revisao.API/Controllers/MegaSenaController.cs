using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MegaSenaController : ControllerBase
	{

		private readonly IJogoService _registroJogoService;
		private readonly IMapper _mapper;

		public MegaSenaController(IJogoService registroJogoService, IMapper mapper)
		{
			_registroJogoService = registroJogoService;
			_mapper = mapper;
		}

		[HttpGet(Name = "ObterTodosOsJogos")]
		public async Task<IActionResult> ObterTodosOsJogos()
		{
			return Ok(await _registroJogoService.ObterTodosOsJogos());
		}


		[HttpPost(Name = "RegistrarNovoJogo")]
		public async Task<IActionResult> RegistrarNovoJogo(JogoViewModel registroJogoViewModel)
		{
			await _registroJogoService.RegistrarJogo(registroJogoViewModel);

            return Ok("Cadastrado com sucesso");
		}
	}
}

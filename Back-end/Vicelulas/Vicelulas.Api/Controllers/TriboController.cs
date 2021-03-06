﻿using Microsoft.AspNetCore.Mvc;
using Vicelulas.Negocio;
using System.Net;

namespace Vicelulas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/organismo/[controller]")]
    [ApiController]
    public class TriboController : ControllerBase
    {
        private readonly TriboNegocio _triboNegocio;


        /// <summary>
        /// EndPoints Tribo API
        /// </summary>
        public TriboController()
        {
            _triboNegocio = new TriboNegocio();

        }

        /// <summary>
        /// Método que obtem uma lista de tribos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]

        public IActionResult Get()
        {
            return Ok(_triboNegocio.Selecionar());
        }

        /// <summary>
        /// Método que seleciona uma tribo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetId(int id)
        {
            var obj = _triboNegocio.SelecionarPorId(id);

            return Ok(obj);
        }


        /// <summary>
        /// Método que obtem lista de tribos com o determinado nome (pesquisa)
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisar/{nome}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetName(string nome)
        {
            var obj = _triboNegocio.SelecionarPorNome(nome);
     
            return Ok(obj);
        }


    }
}
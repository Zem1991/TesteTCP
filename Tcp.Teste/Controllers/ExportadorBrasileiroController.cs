using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tcp.Teste.Domain.Interfaces;
using Tcp.Teste.Infraestrutura.Context.Entities;

namespace Tcp.Teste.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportadorBrasileiroController : ControllerBase
    {
        private readonly IExportadorBrasileiroService _service;

        public ExportadorBrasileiroController(IExportadorBrasileiroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _service.GetAllAsync();
                if (result == null)
                    return BadRequest(result);
                else
                    return Ok(result);
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var result = await _service.GetAllAsync();
                if (result == null)
                    return BadRequest(result);
                else
                    return Ok(result);
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            try
            {
                var result = await _service.GetAllAsync();
                if (result == null)
                    return BadRequest(result);
                else
                    return Ok(result);
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ExportadorBrasileiro value)
        {
            try
            {
                var result = await _service.UpdateAsync(value);
                if (result == null)
                    return BadRequest(result);
                else
                    return Ok(result);
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex);
            }
        }

        protected ObjectResult ExceptionResult(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex);
        }
    }
}

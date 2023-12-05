using Backend.CrossCuting.Common;
using Backend.Domain.Entities.Util;
using Backend.Service.Interface.Maestro;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Backend.RestServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaestroController : ControllerBase
    {
        private readonly IMaestroService _maestroService;
        public MaestroController(IMaestroService maestroService)
        {
            _maestroService = maestroService;
        }

        [HttpGet]
        public async Task<IActionResult> Master()
        {
            ResponseDTO response;
            try
            {
                var data = await _maestroService.MasterDetailInformation("code");
                response = new ResponseDTO { Data = data, Status = Constants.CodigoEstado.Ok };
            }
            catch (FunctionalException ex)
            {
                response = new ResponseDTO { Status = ex.FuntionalCode, Message = ex.Message, Data = ex.Data, TransactionId = ex.TransactionId };
            }
            catch (TechnicalException ex)
            {
                response = new ResponseDTO { Status = ex.ErrorCode, Message = ex.Message, Data = ex.Data, TransactionId = ex.TransactionId };
            }
            catch (Exception ex)
            {
                response = new ResponseDTO { Message = ex.Message, Status = Constants.CodigoEstado.TechnicalError, Data = null };
            }
            return Ok(response);
        }
    }
}

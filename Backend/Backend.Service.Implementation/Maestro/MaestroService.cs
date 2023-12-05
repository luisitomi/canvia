using Backend.Domain.Entities.Util;
using Backend.Infraestructure.UnitOfWork;
using Backend.Service.Interface.Maestro;

namespace Backend.Service.Implementation.Maestro
{
    public class MaestroService : IMaestroService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MaestroService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDTO> MasterDetailInformation(string code)
        {
            var response = new ResponseDTO();
            var master = await _unitOfWork.MaestroRepository.MasterDetailInformation(code);
            response.Data = master;

            return response;
        }
    }
}

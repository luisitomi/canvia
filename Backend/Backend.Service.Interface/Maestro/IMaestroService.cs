using Backend.Domain.Entities.Util;

namespace Backend.Service.Interface.Maestro
{
    public interface IMaestroService
    {
        Task<ResponseDTO> MasterDetailInformation(string code);
    }
}

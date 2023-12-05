using Backend.CrossCuting.DTO.Maestro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Infraestructure.Repository.MaestroRepository
{
    public interface IMaestroRepository
    {
        Task<List<MaestroDTO>> MasterDetailInformation(string code);
    }
}

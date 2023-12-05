using Backend.Infraestructure.Repository.MaestroRepository;
using System;

namespace Backend.Infraestructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IMaestroRepository MaestroRepository { get; }
        void Commit();
        void RollBack();
    }
}

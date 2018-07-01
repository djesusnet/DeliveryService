using PlataformaIHARA.Domain.Core.Commands;
using System;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}

using System.Collections.Generic;
using Depozit.Domain.Models;

namespace Depozit.Infrastructure.Interfaces
{
    public interface IInrStoc
    {
        List<InrStoc> GetStoc(string ConnectionString);
        InrStoc GetInrStoc(string ConnectionString, int Id);
    }
}

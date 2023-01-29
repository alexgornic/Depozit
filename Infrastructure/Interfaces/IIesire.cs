using System.Collections.Generic;
using Depozit.Domain.Models;

namespace Depozit.Infrastructure.Interfaces
{
    public interface IIesire
    {
        List<Iesire> GetIesiri(string ConnectionString);
        Iesire GetIesire(string ConnectionString, int Id);
        void CreateIesire(string ConnectionString, string ProductName, string PartnerName, int Qty);
        void UpdateIesire(string ConnectionString, int Id, string ProductName, string PartnerName, int Qty);
        void DeleteIesire(string ConnectionString, int Id);
    }
}

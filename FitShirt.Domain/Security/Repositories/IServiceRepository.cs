using FitShirt.Domain.Security.Models.Entities;
using FitShirt.Domain.Shared.Repositories;

namespace FitShirt.Domain.Security.Repositories;

public interface IServiceRepository : IBaseRepository<Service>
{
    Task<Service?> GetFreeServiceAsync();
    Task<Service?> GetPremiumServiceAsync();
}
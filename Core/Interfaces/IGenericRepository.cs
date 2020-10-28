using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specifications;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Interfaces
{
  public interface IGenericRepository<T> where T : BaseEntity
  {
    Task<T> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> ListAllAsync();

    Task<T> GetEntityWithSpec(ISpecification<T> spec);
    Task<IReadOnlyList<T>> ListAllAsyncWithSpec(ISpecification<T> spec);
    Task<int> CountAsync(ISpecification<T> spec);
  }
}
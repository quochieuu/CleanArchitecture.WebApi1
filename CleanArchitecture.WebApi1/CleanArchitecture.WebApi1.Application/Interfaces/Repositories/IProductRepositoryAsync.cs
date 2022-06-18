using CleanArchitecture.WebApi1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi1.Application.Interfaces.Repositories
{
    public interface IProductRepositoryAsync : IGenericRepositoryAsync<Product>
    {
        Task<bool> IsUniqueBarcodeAsync(string barcode);
    }
}

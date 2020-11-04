
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        public Task< PagedResult<ProductViewModel>> GetAllByCategory(GetPublicProductPagingRequest request,string languageId);
        public Task<List<ProductViewModel>> GetAll(string languageId);
    }
}

using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecificiation : BaseSpecification<Product>
    {

        public ProductWithFiltersForCountSpecificiation(ProductSpecParams
        productParams)
          : base(x => 
          (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) && 
          (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
          )
         
        {

        }
        
    }
}
using System.Linq;


namespace CBMerch.Models
{
    public class EFCBMerchRepository : ICBMerchRepository
    {
        private CBMerchDbContext context;

        public EFCBMerchRepository(CBMerchDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}

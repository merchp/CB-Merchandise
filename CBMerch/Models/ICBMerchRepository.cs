using System.Linq;


namespace CBMerch.Models
{
    public interface ICBMerchRepository
    {
        IQueryable<Product> Products { get; }
    }
}

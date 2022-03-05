namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float Calculator(TProduct product)
        {
            return product.Price;
        }
    }
}

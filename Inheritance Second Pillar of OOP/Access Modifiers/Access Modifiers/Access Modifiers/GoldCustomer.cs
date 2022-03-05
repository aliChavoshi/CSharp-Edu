namespace Access_Modifiers
{
    public class GoldCustomer : Customer1
    {
        public void OfferVoucher()
        {
            this.CaculateRating(excludeOrders: true);
        }
    }
}

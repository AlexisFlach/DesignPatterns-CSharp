namespace shoppingapp.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public decimal Price { get; set; }

        public int Quantity {get; set;}

        // public override bool Equals(object? obj)
        // {
        //     return obj is Item item &&
        //            Quantity == item.Quantity;
        // }

        // public override int GetHashCode()
        // {
        //     return HashCode.Combine(Quantity);
        // }
    }
}
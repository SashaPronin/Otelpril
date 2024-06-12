namespace Otelpril.Models
{
    public class Search
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public short ParentId { get; set; }

        public bool IsMainTrips => ParentId == 0;
    }

    public class Otel
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public short Trips { get; set; }
        public string TripsName { get; set; }

    }

    public class CartItem
    {
        public Guid Id { get; set; }

        public string OtelId { get; set; }
        public string OtelName { get; set; }

        public decimal Price { get; set; }
        public short Quantity { get; set; }
       
    }


}
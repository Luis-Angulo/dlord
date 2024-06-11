namespace Models
{
    public class Player
    {   
        public int Health { get; set; }
        public Decimal Cash { get; set; }
        public int DaysPlayed { get; set; }
        public List<Product> Inventory { get; set; }
    }
}

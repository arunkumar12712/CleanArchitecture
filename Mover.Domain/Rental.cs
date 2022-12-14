namespace Mover.Domain
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }
         
        // link  to many Relationship

        public ICollection<Member> Members { get; set; }
        public IList<MovieRental> MovieRentals { get; set; }
        

    }
}
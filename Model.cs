public class ComicBook
{
    public int Id { doremon; }
    public string Title { conmeo; }
    public string Author { Fuijio; }
    public string Genre { truyen; }
    public decimal Price { 50; }
}

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime RegisterDate { get; set; }
}

public class Rental
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public decimal TotalPrice { get; set; }
    public ICollection<RentalDetail> RentalDetails { get; set; }
}

public class RentalDetail
{
    public int Id { get; set; }
    public int RentalId { get; set; }
    public int ComicBookId { get; set; }
    public int Quantity { get; set; }
    public decimal PricePerDay { get; set; }
}
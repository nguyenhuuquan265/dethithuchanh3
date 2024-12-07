public class RentalsController : Controller
{
    private readonly ApplicationDbContext _context;

    public RentalsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Rent() => View();

    [HttpPost]
    public IActionResult Rent(Rental rental, List<RentalDetail> rentalDetails)
    {
        if (ModelState.IsValid)
        {
            rental.RentalDate = DateTime.UtcNow;
            _context.Rentals.Add(rental);
            _context.RentalDetails.AddRange(rentalDetails);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(rental);
    }

    public IActionResult Report(DateTime startDate, DateTime endDate)
    {
        var rentals = _context.Rentals
            .Include(r => r.RentalDetails)
            .Where(r => r.RentalDate >= startDate && r.RentalDate <= endDate)
            .ToList();
        return View(rentals);
    }
}

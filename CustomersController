public class CustomersController : Controller
{
    private readonly ApplicationDbContext _context;

    public CustomersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Register() => View();

    [HttpPost]
    public IActionResult Register(Customer customer)
    {
        if (ModelState.IsValid)
        {
            customer.RegisterDate = DateTime.UtcNow;
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "ComicBooks");
        }
        return View(customer);
    }

    // Similar actions for viewing customers...
}
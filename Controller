public class ComicBooksController : Controller
{
    private readonly ApplicationDbContext _context;

    public ComicBooksController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Create, Read, Update, Delete actions for ComicBooks
    public IActionResult Index() => View(_context.ComicBooks.ToList());

    [HttpGet]
    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(ComicBook comicBook)
    {
        if (ModelState.IsValid)
        {
            _context.ComicBooks.Add(comicBook);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(comicBook);
    }

    // Similar actions for Edit, Delete...
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class CalendarModel : PageModel
{
    public IActionResult OnGet()
    {
        return Redirect("https://loopback.social");
    }
}

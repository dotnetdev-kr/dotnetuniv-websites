using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class NotFoundModel : PageModel
{
    public string? RequestedPath { get; private set; }

    public void OnGet()
    {
        RequestedPath = HttpContext.Request.Path.Value;
    }
}

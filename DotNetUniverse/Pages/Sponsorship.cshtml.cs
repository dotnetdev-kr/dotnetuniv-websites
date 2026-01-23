using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetUniverse.Pages;

public class SponsorshipModel : PageModel
{
    public IActionResult OnGet()
    {
        // 기본 후원 안내 페이지는 한국어로 리다이렉트
        return RedirectToPage("/Sponsorship/Ko");
    }
}


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Michaelsoft.BodyGuard.Client.Areas.Result.Pages
{
    public class Success : PageModel
    {

        [TempData]
        public string Message { get; set; }

        public void OnGet()
        {

        }

    }
}
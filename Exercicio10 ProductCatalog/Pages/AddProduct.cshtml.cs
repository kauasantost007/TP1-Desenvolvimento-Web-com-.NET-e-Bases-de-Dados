using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio10.ProductCatalog.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; } = "";

        [BindProperty]
        public decimal Preco { get; set; }

        public bool Enviado { get; set; }

        public void OnPost()
        {
            Enviado = true;
        }
    }
}
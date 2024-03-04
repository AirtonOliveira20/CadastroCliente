using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastroCliente2.Pages.Cliente
{
    public class CadastroModel : PageModel
    {
        [BindProperty]
        public Model.Cliente Cliente { get; set; }

        private  ClienteDbContext _context;

        public CadastroModel(ClienteDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost() 
        { 
            if(ModelState.IsValid==false)
            {
                return Page();
            }
            if(Cliente != null) 
            { 
                this._context.Clientes.Add(Cliente);
                this._context.SaveChanges();
            }
            return RedirectToPage("Lista");

        }
    }
}

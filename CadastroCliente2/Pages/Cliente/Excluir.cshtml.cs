using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastroCliente2.Pages.Cliente
{
    public class ExcluirModel : PageModel
    {

        [BindProperty]
        public Model.Cliente Cliente { get; set; }

        private ClienteDbContext _context;

        public ExcluirModel(ClienteDbContext context)
        {
            _context = context;
        }


        public void OnGet([FromRoute] int id)
        {
            this.Cliente = this._context.Clientes.FirstOrDefault(x => x.Id == id);


        }

        public IActionResult OnPost()
        {
           
            if (Cliente != null)
            {
                this._context.Clientes.Remove(Cliente);
                this._context.SaveChanges();

            }
            return RedirectToPage("Lista");
           
        }
    }
}

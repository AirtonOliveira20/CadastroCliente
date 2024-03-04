using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastroCliente2.Pages.Cliente
{
    public class EditarModel : PageModel
    {
        private ClienteDbContext _context;

        public EditarModel(ClienteDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Model.Cliente Cliente { get; set; }


        public void OnGet([FromRoute] int id)
        {
            this.Cliente = this._context.Clientes.FirstOrDefault(x => x.Id == id);


        }

        public IActionResult OnPost()
        {
            
            if (Cliente != null)
            {
                this._context.Clientes.Update(Cliente);
                this._context.SaveChanges();
            }
            return RedirectToPage("Lista");
        }


    }
}

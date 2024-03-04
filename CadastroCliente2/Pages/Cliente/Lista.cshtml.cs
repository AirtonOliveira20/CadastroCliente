using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastroCliente2.Pages.Cliente
{
    public class ListaModel : PageModel
    {
        private ClienteDbContext _context;

        public List<Model.Cliente> Clientes { get; set; }
        public ListaModel(ClienteDbContext context) 
        {
            _context = context;
        }
        public void OnGet([FromRoute] int id)
        {
            this.Clientes = this._context.Clientes.ToList();
        }
    }
}

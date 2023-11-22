using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiTodo.Controllers; // sert à organiser et regrouper les classes de contrôleurs dans un espace de noms spécifique. Cela permet de mieux structurer et gérer le code source d'une application. En utilisant des namespaces, vous pouvez éviter les conflits de noms entre les classes et faciliter la recherche et la compréhension du code.

[ApiController]  //Les crochets [ApiController] sont un attribut en C# qui est utilisé pour marquer une classe de contrôleur en tant que contrôleur API.

[Route("api/todo")] //chemin de l'api
public class TodoController : ControllerBase // ControllerBase est une classe abstraite qui fournit des fonctionnalités communes aux contrôleurs sans vue.
{
    private readonly TodoContext _context; //readonly => variable qui ne peut être modifiée que dans le constructeur ou avec une initialisation directe.

    public TodoController(TodoContext context) //la var contexte possède toute la bdd (todo etc.) : interface entre la bdd et le programme
    {
        _context = context;
    }


    // GET: api/todo
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Todo>>> GetItems() //methode asynchrone qui retourne une liste d'item via la classe Todo (va chercher Id Nom etc.)
    {
        // Get todos
        var todos = _context.Todo;
        return await todos.ToListAsync();
    }


    
}

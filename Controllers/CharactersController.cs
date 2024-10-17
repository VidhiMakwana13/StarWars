using Microsoft.AspNetCore.Mvc;
using StarWarsCharacters.Models;
using StarWarsCharacters.Services;
using System.Threading.Tasks;

namespace StarWarsCharacters.Controllers
{
    public class CharactersController : Controller
    {
        private readonly StarWarsService _starWarsService;

        public CharactersController(StarWarsService starWarsService)
        {
            _starWarsService = starWarsService;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var response = await _starWarsService.GetCharactersAsync(page);
            return View(response);
        }
    }
}

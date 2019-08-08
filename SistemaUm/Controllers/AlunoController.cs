using Microsoft.AspNetCore.Mvc;
using SistemaUm.Models;
using SistemaUm.Services;
using System.Threading.Tasks;

namespace SistemaUm.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AlunoService _alunoService;

        public AlunoController(AlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _alunoService.FindAllAsync();
            return View( list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("AlunoId,Nome")] Aluno aluno)
        {
            if(ModelState.IsValid)
            {
                await _alunoService.InsertAsync(aluno);
                return View();
            }
            return View(aluno);
        }
    }
}
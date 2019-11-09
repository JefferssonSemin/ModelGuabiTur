using GuabiTur.Site.Data;
using GuabiTur.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GuabiTur.Site.Controllers
{
    public class PessoaController : Controller
    {
        private readonly Context _context;

        public PessoaController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Jeffersson",
                DataNascimento = DateTime.Now,
                Email = "fuchsjeffe@gmail.com"
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            var alunoObter = _context.Alunos.Find(aluno.Id);
            var alunoEmail = _context.Alunos.FirstOrDefault(a => a.Email == "fuchsjeffe@gmail.com");

            aluno.Nome = "ronaldo";
            _context.Alunos.Update(aluno);
            _context.SaveChanges();

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

            return View("_Layout");
        }
    }
}
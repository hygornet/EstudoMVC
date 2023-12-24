using EstudoMVC.Context;
using EstudoMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EstudoMVC.Repositorio
{
    public class RepositorioFuncionario : IRepositorioFuncionario
    {

        private readonly ApplicationDbContext _repositorioFuncionario;

        public RepositorioFuncionario(ApplicationDbContext repositorioFuncionario)
        {
            _repositorioFuncionario = repositorioFuncionario;
        }

        public Funcionario Adicionar(Funcionario funcionario)
        {
            _repositorioFuncionario.Funcionarios.Add(funcionario);
            _repositorioFuncionario.SaveChanges();

            return funcionario;
        }

        public List<Funcionario> GetAllFuncionarios()
        {
            return _repositorioFuncionario.Funcionarios.Include("Setor").ToList();
        }

        public List<Funcionario> SearchFuncionario(string search)
        {
            var funcionarios = _repositorioFuncionario.Funcionarios.Include("Setor").Where(x=>x.NomeFuncionario.Contains(search)).ToList();

            return funcionarios;
        }

        public List<SelectListItem> GetAllSetor()
        {
            var setor = _repositorioFuncionario.Setor.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.NomeSetor
            }).ToList();

            return setor;
        }
    }
}

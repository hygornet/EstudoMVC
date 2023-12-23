using EstudoMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EstudoMVC.Repositorio
{
    public interface IRepositorioFuncionario
    {
        public Funcionario Adicionar(Funcionario funcionario);

        public List<Funcionario> GetAllFuncionarios();

        public List<SelectListItem> GetAllSetor();
    }
}

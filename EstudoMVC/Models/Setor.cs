namespace EstudoMVC.Models
{
    public class Setor
    {
        public int Id { get; set; }

        public string NomeSetor { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}

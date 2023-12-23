using System.ComponentModel.DataAnnotations.Schema;

namespace EstudoMVC.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        public string NomeFuncionario { get; set; }

        public int SetorId { get; set; }

        [ForeignKey("SetorId")]
        public virtual Setor Setor { get; set; }

    } 


}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ITFlow.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "Campo obrigtório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        [Remote("UsuarioExiste", "Usuarios")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigtório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public ICollection<Chamado> Chamados { get; set; }

        public Usuario(int usuarioID, string nome, string senha)
        {
            UsuarioID = usuarioID;
            Nome = nome;
            Senha = senha;
            Chamados = new List<Chamado>();
        }

        public Usuario(int usuarioID, string nome, string senha, ICollection<Chamado> chamados)
        {
            UsuarioID = usuarioID;
            Nome = nome;
            Senha = senha;
            Chamados = chamados;
        }
    }
}

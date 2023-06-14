using System.ComponentModel.DataAnnotations;

namespace ITFlow.Models
{
    public class Chamado
    {
        public int ChamadoID { get; set; }

        [Required(ErrorMessage = "Campo obrigtório")]
        public string Solicitante { get; set; }

        [Required(ErrorMessage = "Campo obrigtório")]
        public string Assunto { get; set; }

        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<Laudo> Laudos { get; set; }

        public Chamado(int chamadoID, string solicitante, string assunto, int usuarioID, Usuario usuario)
        {
            ChamadoID = chamadoID;
            Solicitante = solicitante;
            Assunto = assunto;
            UsuarioID = usuarioID;
            Usuario = usuario;
            Laudos = new List<Laudo>();
        }

        public Chamado(int chamadoID, string solicitante, string assunto, int usuarioID, Usuario usuario, ICollection<Laudo> laudos)
        {
            ChamadoID = chamadoID;
            Solicitante = solicitante;
            Assunto = assunto;
            UsuarioID = usuarioID;
            Usuario = usuario;
            Laudos = laudos;
        }
    }
}
namespace ITFlow.Models
{
    public class Laudo
    {
        public int LaudoID { get; set; }
        public string Descricao { get; set; }
        public Chamado Chamado { get; set; }

        public Laudo(int laudoID, string descricao, Chamado chamado)
        {
            LaudoID = laudoID;
            Descricao = descricao;
            Chamado = chamado;
        }
    }
}
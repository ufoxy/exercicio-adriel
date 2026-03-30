namespace ExercicioAdriel.Models
{
    public class Notificacao
    {
        private List<string> _notificacoes;
        public Notificacao() { }

        public void Adicionar(string mensagem)
        {
            _notificacoes.Add(mensagem);
        }

        public bool TemNotificacao() { }
        public void MostrarPrimeira() => Console.WriteLine(_notificacoes[0]);
    }
}

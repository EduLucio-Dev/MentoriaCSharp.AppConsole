namespace MentoriaCSharp.Fundamentos.Mensageria
{
    internal class Saudacao
    {
        /// <summary>
        /// Metodo para exibir uma saudação ao usuario.
        /// </summary>
        public void ExibirSaudacao(string usuario)
        {
            DateTime horaAtual = DateTime.Now;
            string msg;

            if (horaAtual < DateTime.Parse("12:00"))
            {
                msg = $"Bom dia! {usuario}";
            }
            else if (horaAtual < DateTime.Parse("18:00"))
            {
                msg = $"Boa Tarde! {usuario}";
            }
            else 
            {
                msg = $"Boa noite {usuario}";
            }
            Console.WriteLine(msg + " bons estudos.");
        }
    }
}

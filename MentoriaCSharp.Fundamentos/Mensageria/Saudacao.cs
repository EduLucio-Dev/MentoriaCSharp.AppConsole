namespace MentoriaCSharp.Fundamentos.Mensageria
{
    internal class Saudacao
    {
        public static void ExibirSaudacao()
        {
            DateTime horaAtual = DateTime.Now;
            string msg;

            if (horaAtual < DateTime.Parse("12:00"))
            {
                msg = "Bom dia!";
            }
            else if (horaAtual < DateTime.Parse("18:00"))
            {
                msg = "Boa Tarde!";
            }
            else 
            {
                msg = "Boa noite";
            }
            Console.WriteLine($"{msg} Eduardo! bons estudos.");
        }
    }
}

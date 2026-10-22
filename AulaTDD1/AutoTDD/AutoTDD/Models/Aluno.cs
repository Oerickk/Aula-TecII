namespace AutoTDD.Models
{
    public class Aluno
    {
        private const double MEDIA_MINIMA_APROVAÇÃO = 6;
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        public bool EstaAprovado(double media)
        {
            return media >= MEDIA_MINIMA_APROVAÇÃO;
        }

        public double CalcularMedia()
        {
            return (this.Nota1 + this.Nota2) / 2;
        }
    }
}

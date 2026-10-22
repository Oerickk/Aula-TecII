using AutoTDD.Models;
namespace AulaTDD.Tests
{
    public class AlunoTests
    {

        [Test]
        public void Deve_Aprovar_Aluno_Com_Media_Maior_Ou_Igual_A_Seis()
        {
            //Arragme - preparação
            var aluno = new Aluno
            {
                Nota1 = 7.0,
                Nota2 = 5.0
            };

            //ACT - Execuçãoo
            bool resultado = aluno.EstaAprovado(aluno.CalcularMedia());

            //Assert - verificação
            Assert.IsTrue(resultado, "O aluno devera estar aprovado quando a media for maior ou igual a 6");

        }
        [Test]
        public void Deve_Reprovar_Aluno_Com_Media_Menor_Que_Seis()
        {
            var aluno = new Aluno()
            {
                Nota1 = 4.0,
                Nota2 = 5.0
            };

            bool resultado = aluno.EstaAprovado(aluno.CalcularMedia());

            Assert.That(resultado, Is.False);
            Assert.IsFalse(resultado, "O aluno devera estar aprovado quando a media for maior ou igual a 6");
        }
    }
}
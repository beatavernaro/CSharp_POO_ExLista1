namespace RegistroAcademico
{
    class Program
    {
        class RegistroAcademico
        {
            public string? nomeDoAluno;
            public int? numeroMatricula;
            public string? dataNascimento;
            public bool bolsista = false;
            public string? anoMatricula;
            public double mensalidade = 650.00;

            public double calculaMensalidade()
            {
                if (bolsista == true)
                {
                    mensalidade = mensalidade * 0.5;
                }
                return mensalidade;
            }

            public void imprimeDados()
            {
                Console.WriteLine(
                    $"Aluno: {nomeDoAluno}  |  Data de Nascimento: {dataNascimento}  |  Matricula: {numeroMatricula}"
                );
                Console.WriteLine(
                    $"Ano da matricula: {anoMatricula}  |  Valor da Mensalidade: {mensalidade.ToString("C")}"
                );
            }
        }

        public static void CriaRegistro(string[] args)
        {
            RegistroAcademico aluno1 = new RegistroAcademico();
            aluno1.nomeDoAluno = "Ana Maria";
            aluno1.bolsista = true;
            aluno1.numeroMatricula = 1234;
            aluno1.dataNascimento = "12/03/2000";
            aluno1.anoMatricula = "15/01/2022";

            aluno1.calculaMensalidade();
            aluno1.imprimeDados();
        }
    }
}

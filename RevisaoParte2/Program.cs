using System;
using System.Collections.Generic;

namespace ValidacaoCliente
{
    public class Cliente {
        /* 
            static void Main(string[] args){
            
                    Console.WriteLine(Nome(""));
                    Console.WriteLine(Cpf("00000000000"));
                    DataNascimento();
            
            }
        */

        public static bool Nome(string nome) {
           
           if (nome.Length >= 5) {
               Console.WriteLine($"Tudo certo {nome.Length}");
           } else {
               Console.WriteLine($"Tudo errado {nome.Length}");
           }
           
           return nome.EndsWith(nome);
         
        }

        public static bool Cpf(string cpf) {

            int[] multi1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multi2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string strCpf;
            string digito;
            int soma;
            int resto;

            if(cpf.Length != 11){
                return false;
            }

            if (cpf.Equals("00000000000")) return false;


            strCpf = cpf.Substring(0, 9);
            soma = 0;

            for(int i = 0; i<9; i++){
                soma += int.Parse(strCpf[i].ToString()) * multi1[i];
            }
            
            resto = soma % 11;
            if(resto < 2){
                resto = 0;
            }else{
                resto = 11 - resto;
            }

            digito = resto.ToString();
            strCpf = strCpf + digito;

            soma = 0;

            for(int i=0; i<10; i++){
                soma += int.Parse(strCpf[i].ToString()) * multi2[i];
            }

            resto = soma % 11;

            if(resto < 2){
                resto = 0;
            } else {
                resto = 11 - resto;
            }
            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public static void DataNascimento(){

           string B_date = Console.ReadLine();

            Console.WriteLine(B_date);
        }
    }
}

namespace Turma {
    class Turma {
        public static void Main(string[] args){

            Dictionary<int, string> Alunos = new Dictionary<int, string>(){
                {1001, "Ana" },
                {2002, "Andre" },
                {3003, "Junior" },
            };

            Dictionary<int, double> Notas = new Dictionary<int, double>(){
                {1001, 10.0 },
                {2002, 7.3 },
                {3003, 8.5 },
            };

            Console.WriteLine("Você deseja inserir algum aluno? s/S para sim, n/N para não ");
            string Pergunta = Console.ReadLine();

            if (Pergunta.Equals("s") || Pergunta.Equals("S")) {

                Console.WriteLine("Matricula: ");
                string Nova_matricula = Console.ReadLine();

                Console.WriteLine("Aluno: ");
                string Novo_aluno = Console.ReadLine();

                int matricula = int.Parse(Nova_matricula);

                Alunos.Add(matricula, Novo_aluno);

            } else if(Pergunta.Equals("n") || Pergunta.Equals("N")){

                Console.WriteLine("Você deseja remover algum aluno? ");
                Pergunta = Console.ReadLine();

                if(Pergunta.Equals("s") || Pergunta.Equals("S")){

                    Console.WriteLine("\nMatrícula : Aluno");
                    foreach(KeyValuePair<int, string> aluno in Alunos){
                        Console.WriteLine($"{aluno.Key} : {aluno.Value}");
                    }

                    Console.WriteLine("\nDigite a matricula do aluno: ");
                    int matricula = Int32.Parse(Console.ReadLine());
             

                    if (Alunos.ContainsKey(matricula)) {
                        
                        Alunos.Remove(matricula);
                        Console.WriteLine($"\nVocê removeu {matricula}\n");

                    }else{
                        Console.WriteLine("A matricula inserida não existe.\n");
                    }

                    

                } else if(Pergunta.Equals("n") || Pergunta.Equals("N"))  return;
            }

            Console.WriteLine("Alunos: ");
            foreach (KeyValuePair<int, string> aluno in Alunos) {
                Console.WriteLine($"Matricula: {aluno.Key} | Aluno:  {aluno.Value}");
            }
                
        }  
    }
}

namespace Curso {

}

namespace CertidaoNascimento {

}

namespace Carro {

}

namespace Progressao {

}

namespace Propriedades {

}
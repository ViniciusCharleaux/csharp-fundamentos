namespace exercicios{
    
    class Exercicio1{

        public static void escreveBoasVindas(){
            Console.WriteLine("Digite seu nome!");
            string name = Console.ReadLine();
            Console.WriteLine($"Olá {name}! Seja muito bem vindo.");
        }
    }
}
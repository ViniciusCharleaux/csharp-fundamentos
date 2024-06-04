namespace exercicios{
    
    class Exercicio2{

        public static void concatenaNomeSobrenome(){
            Console.WriteLine("Digite seu primeiro nome!");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome!");
            string sobrenome = Console.ReadLine();
            Console.WriteLine($"{nome} {sobrenome}");
        }
    }
}
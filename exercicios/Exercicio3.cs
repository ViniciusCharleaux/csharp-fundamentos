namespace exercicios{
    
    class Exercicio3{

        public static void fazOperacoesComDoisNumeros(){
            Console.WriteLine("Digite o primeiro valor");
            double valor1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            double valor2 = Double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
            Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
            Console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");
            Console.WriteLine($"{valor1} / {valor2} = {valor1 / valor2}");
            Console.WriteLine($"Média = {(valor1 + valor2) / 2} ");  
            
        }
    }
}
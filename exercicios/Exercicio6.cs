namespace exercicios{
    
    class Exercicio6{

        public static void dataAtual(){
            DateTime data = DateTime.Now;

            Console.WriteLine($"Data Atual: {data}");
            Console.WriteLine($"Data Atual: {data.ToString("dd/MM/yyyy")}");

        }
    }
}
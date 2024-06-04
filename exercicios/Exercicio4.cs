namespace exercicios{
    
    class Exercicio4{

        public static void contaONumeroDeCaracteres(){
            Console.WriteLine("Digite um texto: ");
            string texto = Console.ReadLine();

            int contador = 0;

            if(texto.Length > 0){
                string textoLimpo = texto.Trim();

                foreach(char c in textoLimpo){
                    Console.WriteLine(c);
                    if(c != ' '){
                        contador++;
                    }
                }

        }
            Console.WriteLine("Número de caracteres:"+ contador);

        }
    }
}
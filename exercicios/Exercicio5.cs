namespace exercicios{
    
    class Exercicio5{

        public static void verificaPlacaDeCarro(){
            Console.WriteLine("Digite a placa do seu carro: ");
            string placa = Console.ReadLine();

            bool value = validaPlaca(placa);

            if(value){
                Console.WriteLine("Placa Valida");
            }else{
                Console.WriteLine("Placa Falsa");

            }
        }

        private static bool validaPlaca(string placa){
            Console.WriteLine(placa);
            if(placa.Length == 7){

                string parteLetras = placa[..3];
                string parteNumeros = placa[3..];

                Console.WriteLine(parteLetras);
                Console.WriteLine(parteNumeros);

                bool letras = parteLetras.All(c => Char.IsLetter(c));
                bool numeros = parteNumeros.All(c => Char.IsNumber(c));

                if(letras && numeros){
                    return true;
                }else{
                    return false;
                }
                
            }else{
                return false;
            }  
        }
    }
}
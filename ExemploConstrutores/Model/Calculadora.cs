namespace ExemploConstrutores.Model
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y){
            if(EventoCalculadora != null){
                System.Console.WriteLine($"Soma: {x + y}");
                EventoCalculadora();
            }
            else{
                System.Console.WriteLine($"Não possuí Inscritos");
            }


            
        }

        public static void Subtrair(int x, int y){
            if(EventoCalculadora!=null){
                System.Console.WriteLine($"Subtrair: {x - y}");
                EventoCalculadora();
            }else{
                System.Console.WriteLine($"Não possuí inscritos");
            }

        }


    }
}
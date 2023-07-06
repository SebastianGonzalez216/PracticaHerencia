namespace PracticaHerencia.Modelos
{
    //Clase padre Caninos
    public class Canino
    {
        public string NombreCientifico { get; set; }
        public double Peso { get; set; }

        //metodo ejemplo (todos los caninos pueden correr)
        public void Correr()
        {
            Console.WriteLine("correr");
        }
    }

    //Clase hija PerrosDomesticos

    public class PerroDomestico : Canino
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }

        //metodo ejemplo (los perros pueden ladrar, pero no todos los caninos pueden hacerlo)

        public void Ladrar()
        {
            Console.WriteLine("ladrar");
        }
    }
}

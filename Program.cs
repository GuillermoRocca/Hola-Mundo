namespace Ejercicio {
    public class Program {
        public static void Main(){
            Review r1= new Review ("5", "Muy bueno");
            Review r2= new Review("1","Mal producto");
            Producto p1= new Producto("Milanesa","$23");
            p1.AgregarReview(r1);
            p1.AgregarReview(r2);
            Console.WriteLine(p1);
        }
    }
}

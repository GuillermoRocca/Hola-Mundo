namespace Ejercicio {
public class Producto {
    public string Nombre { get; set; }
    public string Precio { get; set; }
    public List<Review> Lista = new List<Review>();
    public Producto(string nombre, string precio)
    {
        this.Nombre = nombre;
        this.Precio = precio;
    }
    
    public void AgregarReview (Review review){
        this.Lista.Add(review);
    }
    
    public override string ToString() {
        string combinedString = string.Join( "\n", this.Lista );
        return  $"Nombre {this.Nombre}\nPrecio {this.Precio}, \nReviews del Producto: \n{combinedString} ";       
}
}
}
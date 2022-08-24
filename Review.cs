namespace Ejercicio {

public class Review {
    public string Calificacion  { get; set; }
    public string Comentario { get; set; }
    public Review(string calificacion, string comentario)
    {
        this.Calificacion = calificacion;
        this.Comentario= comentario;
    }
    public override string ToString() {
        return $"Reviews del producto:\nComentario:{this.Comentario}\nCalificacion:{this.Calificacion}";
    }
    }
    }
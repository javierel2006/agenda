namespace HojaVidaApp.Models
{
public class Candidato
{
public int Id { get; set; }
public string Nombre { get; set; } = string.Empty;
public string Profesion { get; set; } = string.Empty;
public string Email { get; set; } = string.Empty;
public string Telefono { get; set; } = string.Empty;
public string Resumen { get; set; } = string.Empty; // pequeño resumen profesional
}
}
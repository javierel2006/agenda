using HojaVidaApp.Models;
using System.Collections.Generic;
using System.Linq;


namespace HojaVidaApp.Services
{
public class CandidatoService
{
private readonly List<Candidato> _candidatos;
private int _nextId = 1;


public CandidatoService()
{
_candidatos = new List<Candidato>
{
new Candidato { Id = _nextId++, Nombre = "Ana Pérez", Profesion = "Ingeniera de Sistemas", Email = "ana.perez@example.com", Telefono = "3001112222", Resumen = "Interés en desarrollo web y bases de datos." },
new Candidato { Id = _nextId++, Nombre = "Carlos Ruiz", Profesion = "Analista QA", Email = "carlos.ruiz@example.com", Telefono = "3003334444", Resumen = "Experiencia en pruebas automatizadas." },
new Candidato { Id = _nextId++, Nombre = "María Gómez", Profesion = "Diseñadora UX", Email = "maria.gomez@example.com", Telefono = "3005556666", Resumen = "Especialista en experiencia de usuario." },
new Candidato { Id = _nextId++, Nombre = "Jorge Martínez", Profesion = "Administrador de Sistemas", Email = "jorge.martinez@example.com", Telefono = "3007778888", Resumen = "Gestión de servidores Linux y redes." },
new Candidato { Id = _nextId++, Nombre = "Laura Torres", Profesion = "Desarrolladora Frontend", Email = "laura.torres@example.com", Telefono = "3009990000", Resumen = "React, Blazor y HTML/CSS." }
};
}


public List<Candidato> GetAll() => _candidatos.ToList();


public Candidato? GetById(int id) => _candidatos.FirstOrDefault(c => c.Id == id);


public void Add(Candidato candidato)
{
candidato.Id = _nextId++;
_candidatos.Add(candidato);
}
}
}
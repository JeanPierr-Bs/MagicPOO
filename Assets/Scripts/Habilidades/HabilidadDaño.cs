using System;
using UnityEngine;

public class HabilidadDaño : Habilidad
{
    public int Daño { get; set; }
    public int Radio { get; set; }
    public int Duracion { get; set; }

    public HabilidadDaño(string nombre, string icono, int daño, int radio, int duracion, int coolDown, int costo)
        : base(nombre, icono, TipoHabilidad.Dano, coolDown, costo)
    {
        Daño = daño;
        Radio = radio;
        Duracion = duracion;
    }

    protected override void Ejecutar()
    {
        Console.WriteLine($"{Nombre} inflige {Daño} de daño en un área de {Radio} (duración: {Duracion}s).");
    }
}

using System;
using UnityEngine;

public class HabilidadProyectil : Habilidad
{
    public float Fuerza { get; set; }
    public int Daño { get; set; }

    public HabilidadProyectil(string nombre, string icono, float fuerza, int daño, int coolDown, int costo)
        : base(nombre, icono, TipoHabilidad.Proyectil, coolDown, costo)
    {
        Fuerza = fuerza;
        Daño = daño;
    }

    protected override void Ejecutar()
    {
        Console.WriteLine($"{Nombre}: proyectil lanzado con fuerza {Fuerza}, causando {Daño} de daño.");
    }
}
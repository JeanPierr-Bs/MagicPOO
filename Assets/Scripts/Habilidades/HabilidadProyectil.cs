using System;
using UnityEngine;

public class HabilidadProyectil : Habilidad
{
    public float Fuerza { get; set; }
    public int Da�o { get; set; }

    public HabilidadProyectil(string nombre, string icono, float fuerza, int da�o, int coolDown, int costo)
        : base(nombre, icono, TipoHabilidad.Proyectil, coolDown, costo)
    {
        Fuerza = fuerza;
        Da�o = da�o;
    }

    protected override void Ejecutar()
    {
        Console.WriteLine($"{Nombre}: proyectil lanzado con fuerza {Fuerza}, causando {Da�o} de da�o.");
    }
}
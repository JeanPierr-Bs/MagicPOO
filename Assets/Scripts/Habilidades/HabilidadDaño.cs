using System;
using UnityEngine;

public class HabilidadDa�o : Habilidad
{
    public int Da�o { get; set; }
    public int Radio { get; set; }
    public int Duracion { get; set; }

    public HabilidadDa�o(string nombre, string icono, int da�o, int radio, int duracion, int coolDown, int costo)
        : base(nombre, icono, TipoHabilidad.Dano, coolDown, costo)
    {
        Da�o = da�o;
        Radio = radio;
        Duracion = duracion;
    }

    protected override void Ejecutar()
    {
        Console.WriteLine($"{Nombre} inflige {Da�o} de da�o en un �rea de {Radio} (duraci�n: {Duracion}s).");
    }
}

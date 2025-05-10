using System;
using UnityEngine;

public class HabilidadDanio : Habilidad
{
    public int Da�o { get; set; }
    public int Radio { get; set; }
    public int Duracion { get; set; }

    public HabilidadDanio(string nombre, string icono, int da�o, int radio, int duracion, int coolDown, int costo)
        : base(nombre, icono, TipoHabilidad.Dano, coolDown, costo)
    {
        Da�o = da�o;
        Radio = radio;
        Duracion = duracion;
    }

    protected override void Ejecutar()
    {
        Debug.Log($"{Nombre} inflige {Da�o} de da�o en un �rea de {Radio} (duraci�n: {Duracion}s).");
    }
}

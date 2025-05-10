using System;
using UnityEngine;

public class HabilidadDanio : Habilidad
{
    public int Daño { get; set; }
    public int Radio { get; set; }
    public int Duracion { get; set; }

    public HabilidadDanio(string nombre, string icono, int daño, int radio, int duracion, int coolDown, int costo)
        : base(nombre, icono, TipoHabilidad.Dano, coolDown, costo)
    {
        Daño = daño;
        Radio = radio;
        Duracion = duracion;
    }

    protected override void Ejecutar()
    {
        Debug.Log($"{Nombre} inflige {Daño} de daño en un área de {Radio} (duración: {Duracion}s).");
    }
}

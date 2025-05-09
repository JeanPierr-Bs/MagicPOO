using System;
using UnityEngine;

public class HabilidadCurativa : Habilidad
{
    public int CantidadCuracion { get; set; }

    public HabilidadCurativa(string nombre, string icono, int cantidadCuracion, int coolDown, int costo)
        : base(nombre, icono, TipoHabilidad.Curativa, coolDown, costo)
    {
        CantidadCuracion = cantidadCuracion;
    }

    protected override void Ejecutar()
    {
        Debug.Log($"{Nombre}: cura {CantidadCuracion} puntos de vida.");
    }
}
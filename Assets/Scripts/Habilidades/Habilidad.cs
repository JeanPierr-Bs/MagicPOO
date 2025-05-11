using System;
using UnityEngine;

public abstract class Habilidad: MonoBehaviour
{
    public string Nombre { get; set; }
    public string Icono { get; set; } // Para UI
    public TipoHabilidad Tipo { get; set; }
    public int CoolDown { get; set; }
    public int Costo { get; set; }
    private DateTime UltimoUso;

    public Habilidad(string nombre, string icono, TipoHabilidad tipo, int coolDown, int costo)
    {
        Nombre = nombre;
        Icono = icono;
        Tipo = tipo;
        CoolDown = coolDown;
        Costo = costo;
        UltimoUso = DateTime.MinValue;
    }

    public virtual bool PuedeUsarse()
    {
        return (DateTime.Now - UltimoUso).TotalSeconds >= CoolDown;
    }

    public virtual void Usar()
    {
        if (!PuedeUsarse())
        {
            Debug.Log($"{Nombre} está en enfriamiento.");
            return;
        }
        UltimoUso = DateTime.Now;
        Ejecutar();
    }

    protected abstract void Ejecutar();
}
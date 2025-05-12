using System;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Habilidad: MonoBehaviour
{
    public string Nombre { get; set; }
    public string Icono { get; set; } // Para UI
    public TipoHabilidad Tipo { get; set; }
    public int CoolDown { get; set; }
    public int Costo { get; set; }
    private float UltimoUso;

    public Habilidad(string nombre, string icono, TipoHabilidad tipo, int coolDown, int costo)
    {
        Nombre = nombre;
        Icono = icono;
        Tipo = tipo;
        CoolDown = coolDown;
        Costo = costo;
        UltimoUso = -CoolDown;
    }

    public virtual bool PuedeUsarse()
    {
        return UltimoUso >= CoolDown;
    }

    public virtual void Usar()
    {
        if (!PuedeUsarse())
        {
            Debug.Log($"{Nombre} está en enfriamiento.");
            return;
        }
        Debug.Log($"{Nombre} usada exitosamente.");
        //UltimoUso = DateTime.Now;
        Ejecutar();
    }

    protected abstract void Ejecutar();
}
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
    private float UltimoUso { get; set; }

    public PortadorJugable Portador { get; set; } // <- este es clave

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
        if (Time.time - UltimoUso < CoolDown)
        {
            return false;
        }
        UltimoUso = Time.time;
        return true;
    }

    public virtual void Usar()
    {
        if (!PuedeUsarse())
        {
            Debug.Log($"{Nombre} está en enfriamiento.");
            return;
        }

        Debug.Log($"{Nombre} usada exitosamente."); // <-- este debería verse
        Ejecutar();
    }

    protected abstract void Ejecutar();
}
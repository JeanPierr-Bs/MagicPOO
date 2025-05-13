using System;
using System.Collections.Generic;
using UnityEngine;

public class SistemaHabilidades : MonoBehaviour 
{
    [SerializeField]
    public string Nombre;
    
    public List<Habilidad> Habilidades { get; set; }

    public SistemaHabilidades(string nombre)
    {
        Nombre = nombre;
        Habilidades = new List<Habilidad>();
    }

    public void AgregarHabilidad(Habilidad habilidad)
    {
        if (Habilidades == null) Habilidades = new List<Habilidad>();

        if (Habilidades.Count >= 3)
        {
            Debug.Log("No se pueden agregar más de 3 habilidades.");
            return;
        }
        Habilidades.Add(habilidad);
    }

    public void QuitarHabilidad(Habilidad habilidad) => Habilidades.Remove(habilidad);

    public void LanzarHabilidad(TipoHabilidad tipo)
    {
        foreach (var habilidad in Habilidades)
        {
            if (habilidad.Tipo == tipo)
            {
                habilidad.Usar();
            }
        }
    }

    public void UsarTodas() => Habilidades.ForEach(h => h.Usar());
}
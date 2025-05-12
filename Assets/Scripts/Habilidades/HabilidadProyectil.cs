using System;
using UnityEngine;

public class HabilidadProyectil : Habilidad
{
    private float velocidad;
    private int danio;
    private GameObject prefabProyectil;

    public HabilidadProyectil(string nombre, string icono, float velocidad, int danio, int cooldown, int costo, GameObject prefab)
        : base(nombre, icono, TipoHabilidad.Proyectil, cooldown, costo)
    {
        this.velocidad = velocidad;
        this.danio = danio;
        this.prefabProyectil = prefab;
    }

    protected override void Ejecutar()
    {
        if (Portador == null)
        {
            Debug.LogError("Portador no asignado a la habilidad proyectil.");
            return;
        }

        if (prefabProyectil == null)
        {
            Debug.LogError("Prefab del proyectil no asignado.");
            return;
        }
        Transform puntoDisparo = Portador.PuntoDisparo != null ? Portador.PuntoDisparo : Portador.transform;

        // Instanciar proyectil frente al portador (eje Z en 3D)
        GameObject proyectilGO = GameObject.Instantiate(
            prefabProyectil,
            puntoDisparo.position,
            puntoDisparo.rotation
        );

        Proyectil proyectil = proyectilGO.GetComponent<Proyectil>();
        if (proyectil != null)
        {
            proyectil.Inicializar(velocidad, danio, Portador);
        }
        else
        {
            Debug.LogError("El prefab del proyectil no tiene el script Proyectil.cs.");
        }
    }
}
using System;
using UnityEngine;

public class HabilidadProyectil : Habilidad
{
    [SerializeField]
    public string nombre;
    [SerializeField]
    public string icono;
    //[SerializeField]
    public TipoHabilidad Tipo;
    [SerializeField]
    public float velocidad;
    [SerializeField]
    public int danio;
    [SerializeField]
    public int coolDown;
    [SerializeField]
    public int costo;        
    [SerializeField]
    public GameObject prDisparadorProyectil;

    //public HabilidadProyectil(string nombre, string icono, float velocidad, int danio, int cooldown, int costo, GameObject PrDisparadorProyectil)
    //    : base(nombre, icono, TipoHabilidad.Proyectil, cooldown, costo)
    //{
    //    prDisparadorProyectil = PrDisparadorProyectil;
    //}

    protected override void Ejecutar()
    {
        //if (Portador == null)
        //{
        //    Debug.LogError("Portador no asignado a la habilidad proyectil.");
        //    return;
        //}

        if (prDisparadorProyectil == null)
        {
            Debug.LogError("Prefab del proyectil no asignado.");
            return;
        }
        //Transform puntoDisparo = Portador.PuntoDisparo != null ? Portador.PuntoDisparo : Portador.transform;

        // Instanciar proyectil frente al portador (eje Z en 3D)
        //GameObject proyectilGO = GameObject.Instantiate(prDisparadorProyectil, puntoDisparo.position, puntoDisparo.rotation);

        //DisparadorProyectil disparadorProyectil = proyectilGO.GetComponent<DisparadorProyectil>();
        //if (disparadorProyectil != null)
        //{
        //    //proyectil.Inicializar(velocidad, danio, Portador);
        //    disparadorProyectil.Disparar();

        //}
        //else
        //{
        //    Debug.LogError("El prefab del proyectil no tiene el script Proyectil.cs.");
        //}
    }
}
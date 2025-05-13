using System;
using UnityEngine;

public class HabilidadDanio : Habilidad
{
    public int Da�o { get; set; }
    public int Radio { get; set; }
    public int Duracion { get; set; }

    private GameObject areaPrefab;

    public HabilidadDanio(string nombre, string icono, int da�o, int radio, int duracion, int coolDown, int costo, GameObject prefab)
        : base(nombre, icono, TipoHabilidad.Dano, coolDown, costo)
    {
        Da�o = da�o;
        Radio = radio;
        Duracion = duracion;
        areaPrefab = prefab;
    }

    protected override void Ejecutar()
    {
        //if (Portador == null || areaPrefab == null)
        //{
        //    Debug.LogError("Portador o prefab no asignado.");
        //    return;
        //}
        //GameObject area = GameObject.Instantiate(areaPrefab, Portador.transform.position, Quaternion.identity);
        //AreaDanio script = area.GetComponent<AreaDanio>();
        //script.Inicializar(Da�o, Duracion, Radio, Portador);
    }
}

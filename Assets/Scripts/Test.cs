using System;
using System.Drawing;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField]
    public Text NombrePlayer;
    
    [SerializeField]
    public Slider Vida;
    
    [SerializeField]
    public Slider Mana;

    [SerializeField]
    public GameObject areaDanioPrefab; // Asignas esto en el Inspecto
    [SerializeField]
    public GameObject prefabProyectil;

    public Agente1 Agente => agente1;


    private protected Estadistica estadisticaVida;
    private protected Estadistica estadisticaMana;
    private protected Agente1 agente1;


    private void Awake()
    {
        estadisticaVida = new Estadistica(Vida.minValue, Vida.maxValue, Vida.value);
        estadisticaMana = new Estadistica(Mana.minValue, Mana.maxValue, Mana.value);

        SistemaHabilidades sistemaHabilidades = new SistemaHabilidades("Sistema Habilidades");
        
        agente1 = new Agente1("Mario", "", new Estadistica(0, 50, 50), new Mana(0, 0, 0, TipoCarga.CargaPorTiempo), sistemaHabilidades);
        agente1.PuntoDisparo = GameObject.Find("PuntoDisparo").transform;


        Habilidad habilidadCurativa = new HabilidadCurativa("Curarme", "", 15, 3, 10);
        Habilidad habilidadDanio = new HabilidadDanio("Dañar", "", 30, 3, 3, 10, 15, areaDanioPrefab);
        Habilidad habilidadProyectil = new HabilidadProyectil("Disparar", "", 8f, 20, 15, 30, prefabProyectil);

        agente1.SistemaHabilidades.AgregarHabilidad(habilidadCurativa);
        agente1.SistemaHabilidades.AgregarHabilidad(habilidadDanio);
        agente1.SistemaHabilidades.AgregarHabilidad(habilidadProyectil);

        //agente1.Curar(1);
        //agente1.RecibirDaño(1);
        //agente1.UsarHabilidadConVida(TipoHabilidad.Curativa, 1);
        //agente1.UsarHabilidad(TipoHabilidad.Curativa);

        NombrePlayer.text = agente1.Nombre;
    }

    // Update is called once per frame
    void Update()
    {
        ActualizarUI();
        ControlarHabilidad();
        ControlarEstadistica();
    }

    private void ControlarEstadistica()
    {
        Vida.value += agente1.SistemaHabilidades.Habilidades[0].Costo;
    }

    void ControlarHabilidad()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            agente1.UsarHabilidad(TipoHabilidad.Curativa);
            //agente1.UsarHabilidadConVida(TipoHabilidad.Curativa, 5);
            //agente1.RecibirDaño(10);
            //Debug.Log("El portador tiene -10 de vida");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            agente1.UsarHabilidad(TipoHabilidad.Dano);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            agente1.UsarHabilidad(TipoHabilidad.Proyectil);
        }
    }
    void ActualizarUI()
    {
        if (agente1 != null)
        {
            Vida.value = agente1.Vida.ValorActual;
            //Mana.value = agente1.Mana.ValorActual;

            //agente1.VerificarMuerte();
        }
    }
}

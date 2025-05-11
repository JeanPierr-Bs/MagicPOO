using System;
using System.Drawing;
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

    private protected Estadistica estadisticaVida;
    private protected Estadistica estadisticaMana;
    private protected Agente1 agente1;

    private void Awake()
    {
        estadisticaVida = new Estadistica(Vida.minValue, Vida.maxValue, Vida.value);
        estadisticaMana = new Estadistica(Mana.minValue, Mana.maxValue, Mana.value);

        SistemaHabilidades sistemaHabilidades = new SistemaHabilidades("Sistema Habilidades");
        
        agente1 = new Agente1("Mario", "", new Estadistica(0, 3, 1), new Mana(0, 0, 1, TipoCarga.CargaPorTiempo), sistemaHabilidades);
        
        Habilidad habilidadCurativa = new HabilidadCurativa("Curarme", "", 1, 3, 1);
        Habilidad habilidadDanio = new HabilidadDanio("Dañar", "", 1, 100, 3, 1, 1);
        Habilidad habilidadProyectil = new HabilidadProyectil("Disparar", "", 8f, 1, 1, 1);

        agente1.SistemaHabilidades.AgregarHabilidad(habilidadCurativa);
        agente1.SistemaHabilidades.AgregarHabilidad(habilidadDanio);
        //agente1.SistemaHabilidades.AgregarHabilidad(habilidadProyectil);

        //agente1.Curar(1);
        //agente1.RecibirDaño(1);
        //agente1.UsarHabilidadConVida(TipoHabilidad.Curativa, 1);
        //agente1.UsarHabilidad(TipoHabilidad.Curativa);

        NombrePlayer.text = agente1.Nombre;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {       

    }

    // Update is called once per frame
    void Update()
    {
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
        }
    }
}

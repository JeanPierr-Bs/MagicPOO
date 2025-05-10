using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SistemaHabilidades sistemaHabilidades = new SistemaHabilidades("Sistema Habilidades");
        
        Agente1 agente1 = new Agente1("Mario", new Estadistica(0, 3, 1), new Mana(0, 0, 1, TipoCarga.CargaPorTiempo), sistemaHabilidades);
        
        Habilidad habilidadCurativa = new HabilidadCurativa("Curarme", "", 1, 1, 1);
        Habilidad habilidadDanio = new HabilidadDanio("Dañarme", "", 1, 100, 3, 1, 1);
        Habilidad habilidadProyectil = new HabilidadProyectil("Disparar", "", 8f, 1, 1, 1);

        agente1.SistemaHabilidades.AgregarHabilidad(habilidadCurativa);
        agente1.SistemaHabilidades.AgregarHabilidad(habilidadDanio);
        agente1.SistemaHabilidades.AgregarHabilidad(habilidadProyectil);

        agente1.Curar(1);
        agente1.RecibirDaño(1);
        agente1.UsarHabilidadConVida(TipoHabilidad.Curativa, 1);
        agente1.UsarHabilidad(TipoHabilidad.Curativa);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

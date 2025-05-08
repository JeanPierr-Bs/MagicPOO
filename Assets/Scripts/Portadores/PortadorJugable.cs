using UnityEngine;

public class PortadorJugable : Portador
{
    public Mana Mana { get; set; }
    public SistemaHabilidades SistemaHabilidades { get; set; }

    public PortadorJugable(string nombre, Estadistica vida, Mana mana, SistemaHabilidades sistemaHabilidades)
        : base(nombre, vida)
    {
        Mana = mana;
        SistemaHabilidades = sistemaHabilidades;
    }

    public void UsarHabilidad(TipoHabilidad tipo)
    {
        SistemaHabilidades.LanzarHabilidad(tipo);
    }
}
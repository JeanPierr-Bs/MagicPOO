using UnityEngine;

public class PortadorJugable : Portador
{
    public string Icono { get; set; }
    public Mana Mana { get; set; }
    public SistemaHabilidades SistemaHabilidades { get; set; }

    public PortadorJugable(string nombre, string icono, Estadistica vida, Mana mana, SistemaHabilidades sistemaHabilidades)
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
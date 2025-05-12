using UnityEngine;
public enum TipoZona { Curacion, Danio }

public class ZonaEfecto : MonoBehaviour
{
    //public TipoZona tipo;
    //public int cantidad = 1;

    //private void OnTriggerEnter(Collider other)
    //{
    //    PortadorAdaptable adaptador = other.GetComponent<PortadorAdaptable>();
    //    if (adaptador != null && adaptador.portador != null)
    //    {
    //        switch (tipo)
    //        {
    //            case TipoZona.Curacion:
    //                adaptador.portador.Curar(cantidad);
    //                Debug.Log($"Zona de Curación activada. Se curó {cantidad} puntos.");
    //                break;

    //            case TipoZona.Danio:
    //                adaptador.portador.RecibirDaño(cantidad);
    //                Debug.Log($"Zona de Daño activada. Se recibió {cantidad} puntos de daño.");
    //                break;
    //        }
    //    }
    //}
}

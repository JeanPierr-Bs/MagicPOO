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
    //                Debug.Log($"Zona de Curaci�n activada. Se cur� {cantidad} puntos.");
    //                break;

    //            case TipoZona.Danio:
    //                adaptador.portador.RecibirDa�o(cantidad);
    //                Debug.Log($"Zona de Da�o activada. Se recibi� {cantidad} puntos de da�o.");
    //                break;
    //        }
    //    }
    //}
}

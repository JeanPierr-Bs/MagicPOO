using UnityEngine;

public class DisparadorProyectil : MonoBehaviour
{
    public GameObject prefabProyectil;
    public Transform puntoDisparo;
    public LayerMask capaImpacto;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Clic izquierdo
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100f, capaImpacto))
            {
                Disparar(hit.point);
            }
        }
    }

    void Disparar(Vector3 objetivo)
    {
        GameObject nuevoProyectil = Instantiate(prefabProyectil, puntoDisparo.position, Quaternion.identity);
        Proyectil script = nuevoProyectil.GetComponent<Proyectil>();
        if (script != null)
        {
            script.LanzarHacia(objetivo);
        }
    }
}

using System;
using UnityEngine;

public class DisparadorProyectil : MonoBehaviour
{
    public GameObject prefabProyectil;
    public Transform puntoDisparo;
    public LayerMask capaImpacto;

    private Vector3 objetivo;

    void Update()
    {
        ControlPountoDisparo();
        ControlMouseDisparo();
    }

    private void ControlMouseDisparo()
    {
        if (Input.GetMouseButtonDown(0)) // Clic izquierdo
        {
            Disparar();
        }
    }

    void ControlPountoDisparo()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 100f, capaImpacto))
        {
            objetivo = hit.point;            
        }
        
    }

    public void Disparar()
    {
        GameObject nuevoProyectil = Instantiate(prefabProyectil, puntoDisparo.position, Quaternion.identity);
        Proyectil script = nuevoProyectil.GetComponent<Proyectil>();
        if (script != null)
        {
            script.LanzarHacia(objetivo);
        }
    }
}

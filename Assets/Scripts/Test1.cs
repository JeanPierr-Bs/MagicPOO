using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Test1 : MonoBehaviour
{

    #region Variables UI

    #region Estadisticas

    [Header("Estadisticas UI")]
    [SerializeField]
    public Text NombrePlayer;

    [SerializeField]
    public Slider Vida;

    [SerializeField]
    public Slider Mana;

    #endregion

    [Header("Variables")]
    [SerializeField]
    public GameObject agente;

    [SerializeField]
    public GameObject sistemaHabilidades;

    [SerializeField]
    public GameObject habilidadCurativa;
    
    [SerializeField]
    public GameObject habilidadDanio;
    
    [SerializeField]
    public GameObject habilidadProyectil;

    [SerializeField]
    public GameObject estadisticaVida;

    [SerializeField]
    public GameObject estadisticaMana;

    [SerializeField]
    public GameObject mana;

    //[SerializeField]
    //public GameObject areaDanioPrefab; // Asignas esto en el Inspecto
    //[SerializeField]
    //public GameObject prefabDisparadorProyectil;

    #endregion

    private Test1 _test1;
    private SistemaHabilidades _sistemaHabilidades;
    
    private HabilidadCurativa _habilidadCurativa;
    private HabilidadDanio _habilidadDanio;
    private HabilidadProyectil _habilidadProyectil;

    private Agente1 _agente1;
    private Estadistica _estadisticaVida;
    private Estadistica _estadisticaMana;
    private Mana _mana;

    private void Awake()
    {
        _test1 = GetComponent<Test1>();
        sistemaHabilidades = _test1.sistemaHabilidades;
        _sistemaHabilidades = sistemaHabilidades.GetComponent<SistemaHabilidades>();
        
        agente = _test1.agente;
        _agente1 = agente.GetComponent<Agente1>();

        //habilidadCurativa = _test1.habilidadCurativa;
        //_habilidadCurativa = habilidadCurativa.GetComponent<HabilidadCurativa>();
        //_sistemaHabilidades.AgregarHabilidad(_habilidadCurativa);
        
        //habilidadDanio = _test1.habilidadDanio;
        //_habilidadDanio = habilidadDanio.GetComponent<HabilidadDanio>();
        //_sistemaHabilidades.AgregarHabilidad(_habilidadDanio);

        habilidadProyectil = _test1.habilidadProyectil;
        _habilidadProyectil = habilidadProyectil.GetComponent<HabilidadProyectil>();
        _sistemaHabilidades.AgregarHabilidad(_habilidadProyectil);
        
        //_sistemaHabilidades.AgregarHabilidad(new HabilidadProyectil(_habilidadProyectil.Nombre, _habilidadProyectil.icono, TipoHabilidad.Proyectil, _habilidadProyectil.coolDown, _habilidadProyectil.costo));

        //_agente1.SistemaHabilidades.Habilidades = _sistemaHabilidades.Habilidades;

        estadisticaVida = _test1.estadisticaVida;
        _estadisticaVida = estadisticaVida.GetComponent<Estadistica>();
        estadisticaMana = _test1.estadisticaMana;
        _estadisticaMana = estadisticaMana.GetComponent<Estadistica>();
        mana = _test1.mana;
        //_mana = _mana.GetComponent<Mana>();
        
        NombrePlayer.text = _agente1.nombreAgente;        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        ActualizarUI();
        ControlarHabilidad();
    }
    void ActualizarUI()
    {
        if (_test1 != null)
        {
            Vida.value = _estadisticaVida.ValorActual;            
        }
    }

    void ControlarHabilidad()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            _agente1.UsarHabilidad(TipoHabilidad.Curativa);
            //agente1.UsarHabilidadConVida(TipoHabilidad.Curativa, 5);
            //agente1.RecibirDaño(10);
            //Debug.Log("El portador tiene -10 de vida");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _agente1.UsarHabilidad(TipoHabilidad.Dano);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _agente1.UsarHabilidad(TipoHabilidad.Proyectil);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrarObjeto : MonoBehaviour
{
    LogicaGanar logicaEscena;
    public void Awake()
    {
        logicaEscena = FindObjectOfType<LogicaGanar>();
    }
    public void agarreObjeto()
    {
        logicaEscena.agarraObjeto();
        //agregar cosas y tal-...
        this.gameObject.SetActive(false);
    }
}

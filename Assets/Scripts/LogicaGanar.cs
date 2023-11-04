using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaGanar : MonoBehaviour
{
    public int cantidad;
    public int cantidadObjetivo;
    public Image cartelVictoria;

    public void Awake()
    {
        cartelVictoria.gameObject.SetActive(false);
    }
    public void agarraObjeto()
    {
        cantidad++;
        if (cantidad == cantidadObjetivo)
        {
            //poner cartelito
            cartelVictoria.gameObject.SetActive(true);
        }
    }
}

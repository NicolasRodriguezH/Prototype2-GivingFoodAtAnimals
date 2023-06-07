using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frutas : MonoBehaviour
{
    string[] frutas = { "piña", "mango", "melon", "manzana" };
    //public string frutaBuscada;

    public void Frutass()
    {
        //for (int i = 0; i < 4; i++)
        //{
        //    if (frutas[i] == frutaBuscada)
        //    {
        //        Debug.Log("Disponible " + frutaBuscada);
        //    }
        //    else
        //    {
        //        Debug.Log("no disponible");
        //    }
        //}

        if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = frutas.Length -2; i < frutas.Length; i++)
            {
                Debug.Log("La respuesta es" + frutas[i]);
            }
        }
    }
}

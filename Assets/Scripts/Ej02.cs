using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{

    public int dado1;
    public int dado2;
    public int dado3;
    int dadosEnSeis;

    void Start()
    {
        if (dado1 == 6)
        {
            dadosEnSeis++;
        }
        if (dado2 == 6)
        {
            dadosEnSeis++;
        }
        if (dado3 == 6)
        {
            dadosEnSeis++;
        }

        switch (dadosEnSeis)
        {
            case 1:
                Debug.Log("regular");
                break;

            case 2:
                Debug.Log("muy buen");
                break;

            case 3:
                Debug.Log("exelente");
                break;

            default:
                Debug.Log("insuficiente");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje  obtenido en el lanzamiento de tres dados de un cliente,
//de acuerdo a los siguientes  resultados:  
//• Si los tres dados son seis, mostrar el mensaje “Excelente”
//• Si dos dados son seis, mostrar el mensaje “Muy bien”
//• Si un dado es seis, mostrar el mensaje “Regular”
//• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente” 

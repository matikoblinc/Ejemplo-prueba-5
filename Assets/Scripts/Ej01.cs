using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{
    public string fecha;
    public string nombreComprador;
    public string producto;
    public float cantidadSolicitada;
    public float precioUni;
    float total;

    void Start()
    {
        Debug.Log("Fecha de Compra: " + fecha);
        Debug.Log("Nombre del Comprador: " + nombreComprador);
        Debug.Log("Producto solicitado: " + producto);
        Debug.Log("Cantidad solicitada: " + cantidadSolicitada);
        Debug.Log("Precio Unitario: $" + precioUni);
        total = precioUni * cantidadSolicitada;
        Debug.Log("Total a Pagar: $" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//11.Realizá un programa que resuelva el siguiente problema:  
//Deberá ingresarse por Inspector una fecha de compra (String en el siguiente formato:  YYYYMMDD),
//un nombre de comprador, un nombre de producto y una cantidad y precio del  producto comprado.
//Mostrá a modo de ticket, la información ingresada y el monto a pagar.  Modelo de Ticket:  
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx  
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx

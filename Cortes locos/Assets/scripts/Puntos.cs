using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    public TextMeshProUGUI textoPuntos;  // Referencia al texto del puntaje
    public int puntos = 0;  // Inicialización del puntaje

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto tiene la etiqueta "Objeto" para sumar puntos
        if (other.CompareTag("Objeto"))
        {
            puntos++;  // Incrementar el puntaje
            textoPuntos.text = puntos.ToString();  // Actualizar el texto del puntaje con solo el número
            Destroy(other.gameObject);  // Destruir el objeto con el que se colisionó
        }

        // Verificar si el objeto tiene la etiqueta "ObjetoNegativo" para restar puntos
        else if (other.CompareTag("ObjetoNegativo"))
        {
            puntos--;  // Disminuir el puntaje
            textoPuntos.text = puntos.ToString();  // Actualizar el texto del puntaje con solo el número
            Destroy(other.gameObject);  // Destruir el objeto con el que se colisionó
        }
    }
}

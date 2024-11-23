using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class jugador : MonoBehaviour
{

    private int puntuacion;
    public Text puntuacionText;


    // Start is called before the first frame update
    void Start()
    {
        puntuacion = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2d(Collider2D collision)
    {
        Debug.Log("Hemos detectado una colision");
        puntuacion++;
        puntuacionText.text = puntuacion.ToString();
        Destroy(collision.gameObject);
    }
}

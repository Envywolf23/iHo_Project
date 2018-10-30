using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Collider2D))]

public class ObserverFallas : MonoBehaviour {

    public int NumeroFallas;
    public int contadorFallas;
    public TextMeshProUGUI contadorHud;
    public AudioReproductor reproductor;

    public void Update()
    {
        contadorHud.text = "Fallas = " + contadorFallas.ToString() + "/" + NumeroFallas.ToString();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Papel" || collision.tag == "Vidrio" || collision.tag == "Metal" || collision.tag == "Plastico")
        {
            contadorFallas += 1;
            reproductor.ReproducirMalo();
        }

        
    }


}

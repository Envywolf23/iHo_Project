using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objective : MonoBehaviour {

    public GameObject hud, spawner, timer, objective, señal, spawnerIzq, spawnerDer;
    public TextMeshProUGUI textTimer;
    // public Animator animatorZorro;


    public float contador, timerCuentaRegresiva;

    private bool contando = false;
    private bool desactivar = false;
    private bool activarSeñal = false;

    // Use this for initialization
    void Start() {
        spawnerIzq.SetActive(false);
        spawnerDer.SetActive(false);
        contador = 0;
        timerCuentaRegresiva = 0;
        objective.SetActive(true);
        timer.SetActive(false);
        hud.SetActive(false);
        spawner.SetActive(false);
        señal.SetActive(false);
        
    }

    // Update is called once per frame
    void Update() {
        if(contando == false)
        {
            contador += Time.deltaTime;
        }
      
        if (contador > 2f && contando == false)
        {
            contando = true;
            timer.SetActive(true);
            contador = 0f;
        }

        
        if (contando == true  && desactivar == false)
        {
            timerCuentaRegresiva += Time.deltaTime;
            ActivarSeñal();
        }

    }


    void ActivarSeñal()
    {
        if (timerCuentaRegresiva >= 1f)
        {
            textTimer.text = "3";
        }
        if (timerCuentaRegresiva >= 2f)
        {
            textTimer.text = "2";
        }
        if (timerCuentaRegresiva >= 3f)
        {
            textTimer.text = "1";
        }
        
        if (timerCuentaRegresiva >= 4f)
        {
            timer.SetActive(false);
            señal.SetActive(true);
            timerCuentaRegresiva = 0f;
            activarSeñal = true;
        }

        if (activarSeñal == true)
        {
            if (timerCuentaRegresiva > 1.5f)
            {
                objective.SetActive(false);
                hud.SetActive(true);
                spawner.SetActive(true);
                señal.SetActive(false);
                desactivar = true;
            }
        }
    }

}

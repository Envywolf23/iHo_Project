using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeRecord : MonoBehaviour {

    public Score score;
    public float timeInicial;
    public int MetaScore;
    public GameObject VictoryHud, LoseHud, NormalHud, Playables;
    GameObject[] Botellas;
    ObserverFallas fallasBotellas;
    float timeActual;
    public GameObject spawnerIzq, spawnerDer;

    [SerializeField]
    TextMeshProUGUI text;

	// Use this for initialization
	void Start () {
        fallasBotellas = GameObject.FindObjectOfType<ObserverFallas>();
        timeActual = timeInicial;
        
    }
	
	// Update is called once per frame
	void Update () {

        if(score.score == MetaScore)
        {
            NormalHud.SetActive(false);
            VictoryHud.SetActive(true);
            Playables.SetActive(false);
            Botellas = GameObject.FindGameObjectsWithTag("Bullet");
            
            foreach(GameObject botella in Botellas)
            {
                botella.SetActive(false);
            }

        }

        if(timeActual < timeInicial / 2)
        {
            spawnerIzq.SetActive(true);
        }

        if(timeActual < timeInicial / 3)
        {
            spawnerDer.SetActive(true);
        }

        if (timeActual < 0f)
        {
            if (score.score <= MetaScore)
            {
                NormalHud.SetActive(false);
                LoseHud.SetActive(true);
                Playables.SetActive(false);
                Botellas = GameObject.FindGameObjectsWithTag("Bullet");

                foreach (GameObject botella in Botellas)
                {
                    botella.SetActive(false);
                }
            }

        }

        if (fallasBotellas.contadorFallas == fallasBotellas.NumeroFallas)
        {
            NormalHud.SetActive(false);
            LoseHud.SetActive(true);
            Playables.SetActive(false);
            Botellas = GameObject.FindGameObjectsWithTag("Bullet");

            foreach (GameObject botella in Botellas)
            {
                botella.SetActive(false);
            }
        }

        text.text = "Tiempo = " + timeActual.ToString("F0");

        timeActual -= Time.deltaTime;

      

	}
}

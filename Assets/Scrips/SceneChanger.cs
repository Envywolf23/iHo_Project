using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CambiarNivelUno()
    {
        SceneManager.LoadScene(1);
    }

    public void CambiarNivelDos()
    {
        SceneManager.LoadScene(2);
    }

    public void CambiarNivelTres()
    {
        SceneManager.LoadScene(3);
    }

    public void CambiarMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Salir()
    {
        Application.Quit();
    }
}

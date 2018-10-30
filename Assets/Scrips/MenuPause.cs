using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPause : MonoBehaviour {

    public bool GameIsPaused = false;
    MovementFox Movimiento_Zorro;
    public GameObject pauseMenuUI;
    Musica musica;
    public MovementSpawn spawnMalas;
    public MovementBadBullet moveMalas;

	// Use this for initialization
	void Start () {
        Movimiento_Zorro = GameObject.FindObjectOfType<MovementFox>();
        musica = GameObject.FindObjectOfType<Musica>();
        moveMalas = GameObject.FindObjectOfType<MovementBadBullet>();
	}

    // Update is called once per frame
    void Update() {

     
	}

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        spawnMalas.enPausa = false;
        moveMalas.enPausa = false;
        musica.GetComponent<AudioSource>().UnPause();

        if(Movimiento_Zorro != null)
        {
            Movimiento_Zorro.EnPausa = false;
        }

    }

    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        spawnMalas.enPausa = true;
        moveMalas.enPausa = true;
        musica.GetComponent<AudioSource>().Pause();

        if (Movimiento_Zorro != null)
        {
            Movimiento_Zorro.EnPausa = true;
        }

    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        musica.GetComponent<AudioSource>().UnPause();
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }

    private void OnMouseDown()
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject telaPause;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Fase");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SairGame()
    {
        Application.Quit();
    }

    public void PauseMenu()
    {
        telaPause.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Continuar()
    {
        telaPause.SetActive(false);
        Time.timeScale = 1.0f;
    }
}

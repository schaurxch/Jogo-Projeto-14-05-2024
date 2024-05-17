using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenaSelecaoMapa : MonoBehaviour
{
    public void CarregarCenaSelecaoMapas()
    {
        SceneManager.LoadScene("MenuObjetivoDoJogo");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

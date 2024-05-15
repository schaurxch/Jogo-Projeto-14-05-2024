using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecionarMapa : MonoBehaviour
{
    public void CarregarCenaIlha()
    {
        SceneManager.LoadScene("Ilha");
    }

    public void CarregarCenaOceano()
    {
        SceneManager.LoadScene("Oceano");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public int LixoNecessario = 100;
    //public Text VitoriaTexto;
    public ColetaLixo coletalixo;
    public bool fimDeJogoVitoria = false;


    void Update()
    {
        if (coletalixo.lixoColetado >= LixoNecessario)
        {
            fimDeJogoVitoria = true;
            SceneManager.LoadScene("MenuFimDeJogo");
        }
    }
}

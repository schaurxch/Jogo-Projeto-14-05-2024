using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
    public float tempoRestante = 60f; // Tempo inicial em segundos
    public Text textoTempo;
    public Victory vitoria;

    void Update()
    {
        tempoRestante -= Time.deltaTime;
        textoTempo.text = "Tempo: " + tempoRestante.ToString();

        if (tempoRestante <= 0)
        {
            // Verificar condição de vitória/derrota
            if(vitoria.fimDeJogoVitoria == true)
            {
                Debug.Log("VOCE GANHOU");
                //SceneManager.LoadScene("MenuFimDeJogo");
            }
            else
            {
                SceneManager.LoadScene("MenuFimDeJogo");
            }
        }
    }
}

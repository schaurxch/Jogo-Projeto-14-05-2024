using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaLixo : MonoBehaviour
{
    public int lixoColetado = 0;
    public Text pontuacaoTexto;
    public GameObject lixoPrefab;
    public Cronometro cronometro;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trash")
        {
            cronometro.remainingTime += 3f;
            lixoColetado+=5;
            pontuacaoTexto.text = "PONTOS: " + lixoColetado;
            Debug.Log(lixoColetado);
            Destroy(other.gameObject);
        }
    }
}

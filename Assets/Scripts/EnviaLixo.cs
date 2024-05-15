using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviaLixo : MonoBehaviour
{
    public GameObject LixoPrefab;
    public float SendTimer = 1f;
    public float Frequency = 3f;
    public float alcanceX = 5f;
    public float alcanceZ = 5f;


    private void Update()
    {
        SendTimer -= Time.deltaTime;

        if( SendTimer <= 0 )
        {
            GerarLixo();
            SendTimer = Frequency;
        }

    }
    void GerarLixo()
    {
        Vector3 posicaoJogador = transform.position;
        float xAleatorio = Random.Range(-alcanceX, alcanceX);
        float zAleatorio = Random.Range(-alcanceZ, alcanceZ);

        Vector3 posicaoGeracao = new Vector3(posicaoJogador.x + xAleatorio, 1, posicaoJogador.z + zAleatorio);

        Instantiate(LixoPrefab, posicaoGeracao, Quaternion.identity);
    }
}

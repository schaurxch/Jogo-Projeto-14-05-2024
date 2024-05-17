using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Cronometro : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] public float remainingTime = 60f;
    void Start()
    {

    }


    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;
            SceneManager.LoadScene("MenuDerrota");
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
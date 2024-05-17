using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFimDeJogo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None; Cursor.visible = true;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

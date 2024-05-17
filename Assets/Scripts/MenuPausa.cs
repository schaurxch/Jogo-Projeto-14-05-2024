using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public static bool jogoPausado = false;
    public GameObject menuPausaUI;
    
    private ColetaLixo coletalixo;
    

    private void Start()
    {
        menuPausaUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (jogoPausado)
            {
                RetomarJogo();
            }
            else
            {
                PausarJogo();
            }
        }
    }

    public void RetomarJogo()
    {
        Cursor.lockState = CursorLockMode.Locked; Cursor.visible = false;
        menuPausaUI.SetActive(false);
        Time.timeScale = 1f;
        jogoPausado = false;
    }

    void PausarJogo()
    {
        Cursor.lockState = CursorLockMode.None; Cursor.visible = true;
        menuPausaUI.SetActive(true);
        Time.timeScale = 0f;
        jogoPausado = true;
    }

    public void VoltarMenuInicial()
    {
        SceneManager.LoadScene("MenuInicial");
    }
}

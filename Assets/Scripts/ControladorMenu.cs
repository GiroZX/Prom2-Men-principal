using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    public void Play() 
    {
        SceneManager.LoadScene("Scene1");
    }

    public void EscogerNivel(string levelName)
    {
        SceneManager.LoadScene("Level Select");
    }
    public void Opciones() 
    {
        SceneManager.LoadScene("Options");
    }

    public void Exit() 
    {
        Debug.Log("QUIT!");
        
            Application.Quit(); ;

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorBotones : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Scene3");
    }
    public void Return()
    {

        SceneManager.LoadScene("MainMenu");
    }
    public void Back()
    {

        SceneManager.LoadScene("Level Select");
    }
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

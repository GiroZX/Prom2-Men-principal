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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorBack : MonoBehaviour
{
    public void Back()
    {

        SceneManager.LoadScene("Level Select");
    }
}

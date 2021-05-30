using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorReturn : MonoBehaviour
{
    public void Return() {

        SceneManager.LoadScene("MainMenu");
    }
}

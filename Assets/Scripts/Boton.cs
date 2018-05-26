using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour {
   
void Start()
    {
        SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);

    }
}

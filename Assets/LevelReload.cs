using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReload : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //загружаем сцену, получая название текущей сцены
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

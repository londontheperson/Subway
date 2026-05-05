using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScenes : MonoBehaviour
{
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "scene11")
            BGmusic.instance.GetComponent<AudioSource>().Pause();


    }
}

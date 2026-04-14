using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class PlayerDestroy : MonoBehaviour
{
    // public variable used to determine the fall height
    public float deathY = -5.0f;

  

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= deathY)
        {

            Scene scene = SceneManager.GetActiveScene();

            Debug.Log("I died");
            Destroy(gameObject);
            SceneManager.LoadScene(scene.name);

        }
    }
}

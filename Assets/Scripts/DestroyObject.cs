using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{
    float lifetime = 0;
    public GameObject Target;

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            lifetime = 3.0f;
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            lifetime = 2.0f;
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            lifetime = 1.0f;
        }
        Destroy(Target, lifetime);
    }
}

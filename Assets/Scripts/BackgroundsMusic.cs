using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundsMusic : MonoBehaviour
{
    private static BackgroundsMusic backgroundMusic;

    void Awake()
    {
        if (backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}



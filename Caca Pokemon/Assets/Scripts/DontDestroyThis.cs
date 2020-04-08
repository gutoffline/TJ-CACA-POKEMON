using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyThis : MonoBehaviour
{
    private static DontDestroyThis musicaInstance;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
        if (musicaInstance == null) {
            musicaInstance = this;
        } else {
            Destroy(gameObject);
        }
    }
}

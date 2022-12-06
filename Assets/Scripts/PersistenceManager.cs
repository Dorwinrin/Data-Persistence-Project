using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenceManager : MonoBehaviour
{
    public static PersistenceManager Instance;
    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

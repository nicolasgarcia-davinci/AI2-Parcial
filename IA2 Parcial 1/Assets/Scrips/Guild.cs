using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guild : MonoBehaviour
{
    public List<Party> Partys;

    public static Guild Instance;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else Destroy(this);
    }
    void Update()
    {
        
    }
}

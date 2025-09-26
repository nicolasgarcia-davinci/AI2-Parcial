using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dungeon : MonoBehaviour
{
    public List<Monster> Habitants;

    void Start()
    {
        GameMaster.Instance.Domains.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

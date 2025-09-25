using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Monster
{
    void Start()
    {
        Lair = GetComponentInParent<Dungeon>();
        Lair.Habitants.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

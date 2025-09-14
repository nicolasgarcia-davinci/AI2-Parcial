using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berserker : Character
{
    void Start()
    {
        MyParty = GetComponentInParent<Party>();
        MyParty.PartyComp.Add(this);
    }
    void Update()
    {
        
    }
}

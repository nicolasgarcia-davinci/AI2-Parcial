using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
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

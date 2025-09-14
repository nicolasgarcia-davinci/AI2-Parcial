using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour
{
    public List<Character> PartyComp;
    void Start()
    {
        Guild.Instance.Partys.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

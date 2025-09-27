using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour
{
    public string PartyName;
    public List<Character> PartyComp;
    void Start()
    {
        Guild.Instance.Partys.Add(this);
    }
    void Update()
    {

    }
}

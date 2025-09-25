using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public Dungeon Lair;
    public string Name;
    public int MaxHP;
    public int MaxMP;
    public int GoldReward;
    public int XPReward;
    public int Lvl;
    public Race ThisRace;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public enum Race
{
    Demon, Beast, Humanoid, Insect, Undead, Machine, Fey
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name;
    public int CurrentHP;
    public int MaxHP;
    public int CurrentMP;
    public int MaxMP;
    public int Gold;
    public int CurrentXP;
    public int XPToNextLvl;
    public int Lvl;
    public Weapon MyWeapon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum Weapon
{
    Sword,Spear,Bow,Scepter,BroadSword,Dagger,Wand
}

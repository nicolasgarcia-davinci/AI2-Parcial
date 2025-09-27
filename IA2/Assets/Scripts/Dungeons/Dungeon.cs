using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Dungeon : MonoBehaviour
{
    public List<Monster> Habitants;
    public string Name;

    void Start()
    {
        GameMaster.Instance.Domains.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float CalculateDungeonLevel() //agregate  - Nicolas Garcia
    {
        var monsterLvls = Habitants.Select(x=> x.Lvl);
        int monsterAmount=monsterLvls.Count();            
        var allLvls = monsterLvls.Aggregate(0, (acum, monsterLvls) => acum + monsterLvls);

        return allLvls/monsterAmount;
    }
}

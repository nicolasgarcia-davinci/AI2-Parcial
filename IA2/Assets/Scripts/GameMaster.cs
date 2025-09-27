using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameMaster : MonoBehaviour
{

    public List<Dungeon> Domains;
    public Guild Guild;

    public static GameMaster Instance;
    // Start is called before the first frame update

    public void Awake()
    {
        if (Instance == null) Instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Alpha2))
        {
            DungeonRank();
        }
    }
    public void DungeonRank() //Funcion Linq 2: select (en Dungeons con el Agregate) , OrderBy, tolist - Nicolas Garcia
    {
        var Rank= Domains.Select(x=> x.CalculateDungeonLevel());
        var Order = Rank.OrderBy(x => x);
        Debug.Log(Order);
    }
}

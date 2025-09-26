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
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class Guild : MonoBehaviour
{
    public List<Party> Partys;

    public static Guild Instance;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else Destroy(this);
    }
    void Update()
    {
        
    }

    public IEnumerator<PartyAnalysis> AnalyzePartiesPerformance()
    {
        var allParties = Partys?.Where(p => p.PartyComp != null && p.PartyComp.Count > 0).ToList() ?? new List<Party>();
        
        for (int i = 0; i < allParties.Count; i += 2)
        {
            var currentBatch = allParties.Skip(i).Take(2).ToList();
            
            foreach (var party in currentBatch)
            {
                var partyCharacters = party.PartyComp.ToList();
                
                var orderedCharacters = partyCharacters.OrderByDescending(c => c.Lvl).ToList();
                
                var validCharacters = orderedCharacters.Where(c => c.CurrentHP > 0).ToList();
                
                var hasInjuredMembers = validCharacters.Any(c => c.CurrentHP < c.MaxHP * 0.5f);
                
                var analysis = new PartyAnalysis
                {
                    PartyName = party.PartyName,
                    TotalLevel = validCharacters.Sum(c => c.Lvl),
                    InjuredCount = validCharacters.Count(c => c.CurrentHP < c.MaxHP * 0.3f),
                    HasBalanceIssues = hasInjuredMembers,
                    TopCharacter = orderedCharacters.FirstOrDefault()?.Name ?? "None"
                };

                yield return analysis;
            }
            
            if (i + 2 < allParties.Count)
                yield return null;
        }
    }
}

public class PartyAnalysis
{
    public string PartyName;
    public int TotalLevel;
    public int InjuredCount;
    public bool HasBalanceIssues;
    public string TopCharacter;
}

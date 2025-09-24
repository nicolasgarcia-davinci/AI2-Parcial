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
    }
    void Update()
    {
        
    }

    public void AnalyzeWeaponDistribution() //Funcion Linq 1: SelectMany, Where, ToList, junto al Aggregate complejo
    {
        var allCharacters = Partys
            .SelectMany(party => party.PartyComp)
            .Where(c => c != null)
            .ToList();

        if (allCharacters.Count == 0)
        {
            return;
        }
        var weaponCounts = allCharacters.Aggregate(
            new Dictionary<Weapon, int>(),
            (acc, character) => {
                if (acc.ContainsKey(character.MyWeapon)) {
                    acc[character.MyWeapon]++;
                } else {
                    acc[character.MyWeapon] = 1;
                }
                return acc;
            }
        );
        //Tipo anonimo
        var summary = weaponCounts.Select(kv => new { WeaponType = kv.Key, Count = kv.Value });
        foreach (var item in summary)
        {
            Debug.Log($"Weapon: {item.WeaponType}, Count: {item.Count}");
        }
    }

    // Funcion Linq 2: Where, ToList, OrderByDescending, FirstOrDefault, junto a la Tupla y el TimeSlicing
    public IEnumerator<(string PartyName, string TopCharacter)> AnalyzePartiesPerformance()
    {
        var allParties = Partys?.Where(p => p.PartyComp != null && p.PartyComp.Count > 0).ToList() ?? new List<Party>();
    
        for (int i = 0; i < allParties.Count; i++)
        {
            var party = allParties[i];

            var partyCharacters = party.PartyComp.ToList();
        
            var orderedCharacters = partyCharacters.OrderByDescending(c => c.Lvl).ToList();
        
            var validCharacters = orderedCharacters.Where(c => c.CurrentHP > 0).ToList();
        
            var topChar = orderedCharacters.FirstOrDefault()?.Name ?? "None";

            //Tupla
            var result = (party.PartyName, topChar);
            Debug.Log($"Party: {result.PartyName}, Top Character: {result.topChar}");

            yield return result;
        
            if (i < allParties.Count - 1)
                yield break;
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
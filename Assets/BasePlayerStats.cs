using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerStats : MonoBehaviour
{
    public string ArcherName { get; protected set; }
    public int ArcherHealth { get; protected set; }
    public int ArcherAttack { get; protected set; }
    public int ArcherDefense { get; protected set; }

    public string CompanionKnightName { get; protected set; }
    public int CompanionKnightHealth { get; protected set; }
    public int CompanionKnightAttack { get; protected set; }
    public int CompanionKnightDefense { get; protected set; }


    public string DemonKingName { get; protected set; }
    public int DemonKingHealth { get; protected set; }
    public int DemonKingAttack { get; protected set; }
    public int DemonKingDefense { get; protected set; }


    public string MageName { get; protected set; }
    public int MageHealth { get; protected set; }
    public int MageAttack { get; protected set; }
    public int MageDefense { get; protected set; }


    public string SwordsmanName { get; protected set; }
    public int SwordsmanHealth { get; protected set; }
    public int SwordsmanAttack { get; protected set; }
    public int SwordsmanDefense { get; protected set; }


    public virtual void SetNameStat(string text)
    {
        
    }

    public virtual void SetHealthStat(int intValue)
    {

    }

    public virtual void SetAttackStat(int intValue)
    {

    }

    public virtual void SetDefenseStat(int intValue)
    {

    }
}

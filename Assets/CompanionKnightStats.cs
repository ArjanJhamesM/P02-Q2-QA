using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionKnightStats : BasePlayerStats
{
    public override void SetNameStat(string text)
    {
        CompanionKnightName = text;
    }

    public override void SetHealthStat(int intValue)
    {
        CompanionKnightHealth = intValue;
    }

    public override void SetAttackStat(int intValue)
    {
        CompanionKnightAttack = intValue;
    }

    public override void SetDefenseStat(int intValue)
    {
        CompanionKnightDefense = intValue;
    }
}

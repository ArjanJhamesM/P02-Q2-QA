using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonKingStats : BasePlayerStats
{
    public override void SetNameStat(string text)
    {
        DemonKingName = text;
    }

    public override void SetHealthStat(int intValue)
    {
        DemonKingHealth = intValue;
    }

    public override void SetAttackStat(int intValue)
    {
        DemonKingAttack = intValue;
    }

    public override void SetDefenseStat(int intValue)
    {
        DemonKingDefense = intValue;
    }
}

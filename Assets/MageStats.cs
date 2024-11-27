using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageStats : BasePlayerStats
{
    public override void SetNameStat(string text)
    {
        MageName = text;
    }

    public override void SetHealthStat(int intValue)
    {
        MageHealth = intValue;
    }

    public override void SetAttackStat(int intValue)
    {
        MageAttack = intValue;
    }

    public override void SetDefenseStat(int intValue)
    {
        MageDefense = intValue;
    }
}

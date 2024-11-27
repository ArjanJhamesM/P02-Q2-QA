using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherStats : BasePlayerStats // Inheritance
{
    public override void SetNameStat(string text)
    {
        ArcherName = text;
    }

    public override void SetHealthStat(int intValue)
    {
        ArcherHealth = intValue;
    }

    public override void SetAttackStat(int intValue)
    {
        ArcherAttack = intValue;
    }

    public override void SetDefenseStat(int intValue)
    {
        ArcherDefense = intValue;
    }
}

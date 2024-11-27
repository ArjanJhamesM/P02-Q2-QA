using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordsmanStats : BasePlayerStats
{
    public override void SetNameStat(string text)
    {
        SwordsmanName = text;
    }

    public override void SetHealthStat(int intValue)
    {
        SwordsmanHealth = intValue;
    }

    public override void SetAttackStat(int intValue)
    {
        SwordsmanAttack = intValue;
    }

    public override void SetDefenseStat(int intValue)
    {
        SwordsmanDefense = intValue;
    }
}

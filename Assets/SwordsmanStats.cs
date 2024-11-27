using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordsmanStats : BasePlayerStats
{
    public string SwordsmanName = Name("Swordsman");
    public int SwordsmanHealth = Health(100);
    public int SwordsmanAttack = Attack(38);
    public int SwordsmanDefense = Defense(75);
}

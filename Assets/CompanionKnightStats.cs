using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionKnightStats : BasePlayerStats
{
    public string CompanionKnightName = Name("Companion Knight");
    public int CompanionKnightHealth = Health(100);
    public int CompanionKnightAttack = Attack(45);
    public int CompanionKnightDefense = Defense(70);
}

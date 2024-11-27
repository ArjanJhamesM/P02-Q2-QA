using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageStats : BasePlayerStats
{
    public string MageName = Name("Mage");
    public int MageHealth = Health(100);
    public int MageAttack = Attack(60);
    public int MageDefense = Defense(80);
}

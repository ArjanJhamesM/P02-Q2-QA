using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherStats : BasePlayerStats // Inheritance
{
    public string ArcherName = Name("Archer");
    public int ArcherHealth = Health(100);
    public int ArcherAttack = Attack(55);
    public int ArcherDefense = Defense(30);
}

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GUICode : MonoBehaviour
{
    ArcherStats archerStats;
    CompanionKnightStats companionKnightStats;
    DemonKingStats demonKingStats;
    MageStats mageStats;
    SwordsmanStats swordsmanStats;

    private string WinOrLoseText;

    private string archerName;
    [SerializeField] private int archerHealth;
    private int archerAttack;
    private int archerDefense;

    private string companionKnightName;
    private int companionKnightHealth;
    private int companionKnightAttack;
    private int companionKnightDefense;

    private string demonKingName;
    [SerializeField] private int demonKingHealth;
    [SerializeField] private int demonKingAttack;
    private int demonKingDefense;

    private string mageName;
    private int mageHealth;
    private int mageAttack;
    private int mageDefense;

    private string swordsmanName;
    private int swordsmanHealth;
    private int swordsmanAttack;
    private int swordsmanDefense;

    [SerializeField] private string currentPlayerName;
    [SerializeField] private int currentPlayerHealth;
    [SerializeField] private int currentPlayerAttack;
    [SerializeField] private int currentPlayerDefense;

    private string currentPlayerStats;
    private string currentBossStats;
    private string companionKnightPlayerStats;
    private string archerPlayerStats;
    private string magePlayerStats;
    private string swordsmanPlayerStats;
    private string demonKingPlayerStats;

    private int damagedBossHealth;
    private int damagedPlayerHealth;
    private int damagedKnightHealth;

    [SerializeField] private Vector2 position;
    [SerializeField] private Vector2 size;
    [SerializeField] private Vector2 position2;
    [SerializeField] private Vector2 size2;
    [SerializeField] private Vector2 position3;
    [SerializeField] private Vector2 size3;
    [SerializeField] private string text;

    private void Start()
    {
        archerStats = new ArcherStats();
        companionKnightStats = new CompanionKnightStats();
        demonKingStats = new DemonKingStats();
        mageStats = new MageStats();
        swordsmanStats = new SwordsmanStats();

/*        position = new Vector2();
        size = new Vector2();
        position2 = new Vector2();
        size2 = new Vector2();
        position3 = new Vector2();
        size3 = new Vector2();*/

        demonKingStats.SetNameStat("Demon King");
        demonKingName = demonKingStats.DemonKingName;

        demonKingStats.SetHealthStat(500);
        demonKingHealth = demonKingStats.DemonKingHealth;

        demonKingStats.SetAttackStat(70);
        demonKingAttack = demonKingStats.DemonKingAttack;

        demonKingStats.SetDefenseStat(100);
        demonKingDefense = demonKingStats.DemonKingDefense;


        archerStats.SetNameStat("Archer");
        archerName = archerStats.ArcherName;

        archerStats.SetHealthStat(100);
        archerHealth = archerStats.ArcherHealth;

        archerStats.SetAttackStat(45);
        archerAttack = archerStats.ArcherAttack;

        archerStats.SetDefenseStat(50);
        archerDefense = archerStats.ArcherDefense;


        companionKnightStats.SetNameStat("Companion Knight");
        companionKnightName = companionKnightStats.CompanionKnightName;

        companionKnightStats.SetHealthStat(100);
        companionKnightHealth = companionKnightStats.CompanionKnightHealth;

        companionKnightStats.SetAttackStat(35);
        companionKnightAttack = companionKnightStats.CompanionKnightAttack;

        companionKnightStats.SetDefenseStat(50);
        companionKnightDefense = companionKnightStats.CompanionKnightDefense;


        mageStats.SetNameStat("Mage");
        mageName = mageStats.MageName;

        mageStats.SetHealthStat(125);
        mageHealth = mageStats.MageHealth;

        mageStats.SetAttackStat(70);
        mageAttack = mageStats.MageAttack;

        mageStats.SetDefenseStat(60);
        mageDefense = mageStats.MageDefense;


        swordsmanStats.SetNameStat("Swordsman");
        swordsmanName = swordsmanStats.SwordsmanName;

        swordsmanStats.SetHealthStat(110);
        swordsmanHealth = swordsmanStats.SwordsmanHealth;

        swordsmanStats.SetAttackStat(55);
        swordsmanAttack = swordsmanStats.SwordsmanAttack;

        swordsmanStats.SetDefenseStat(75);
        swordsmanDefense = swordsmanStats.SwordsmanDefense;

        currentPlayerStats = "Name: " + currentPlayerName +
            "\nHealth: " + currentPlayerHealth +
            "\nAttack: " + currentPlayerAttack +
            "\nDefense: " + currentPlayerDefense;

        currentBossStats = "Name: " + demonKingName +
            "\nHealth: " + demonKingHealth +
            "\nAttack: " + demonKingAttack +
            "\nDefense: " + demonKingDefense;

        companionKnightPlayerStats = "Name: " + companionKnightName +
            "\nHealth: " + companionKnightHealth +
            "\nAttack: " + companionKnightAttack +
            "\nDefense: " + companionKnightDefense;

        archerPlayerStats = "Name: " + archerName +
            "\nHealth: " + archerHealth +
            "\nAttack: " + archerAttack +
            "\nDefense: " + archerDefense;

        magePlayerStats = "Name: " + mageName +
            "\nHealth: " + mageHealth +
            "\nAttack: " + mageAttack +
            "\nDefense: " + mageDefense;

        swordsmanPlayerStats = "Name: " + swordsmanName +
            "\nHealth: " + swordsmanHealth +
            "\nAttack: " + swordsmanAttack +
            "\nDefense: " + swordsmanDefense;

        demonKingPlayerStats = "Name: " + demonKingName +
            "\nHealth: " + demonKingHealth +
            "\nAttack: " + demonKingAttack +
            "\nDefense: " + demonKingDefense;

        damagedBossHealth = demonKingHealth - currentPlayerAttack;

        
    }

    private void OnGUI()
    {
        /*archerStats = new ArcherStats();
        companionKnightStats = new CompanionKnightStats();
        demonKingStats = new DemonKingStats();
        mageStats = new MageStats();
        swordsmanStats = new SwordsmanStats();*/


        GUI.Box(new Rect(10, 10, 1080, 600), ""); // Screen box

        GUI.Label(new Rect(520, 30, 100, 100), WinOrLoseText); // Win or Lose text

        GUI.Box(new Rect(350, 75, 400, 175), currentBossStats); // Boss stats

        GUI.Box(new Rect(130, 325, 400, 175), currentPlayerStats); // Current player stats

        GUI.Box(new Rect(580, 325, 400, 175), companionKnightPlayerStats); // Companion Knight stats


        if (GUI.Button(new Rect(250, 540, 175, 38), archerName))
        {
            currentPlayerName = archerName;
            currentPlayerHealth = archerHealth;
            currentPlayerAttack = archerAttack;
            currentPlayerDefense = archerDefense;
            currentPlayerStats = archerPlayerStats;
        }

        if (GUI.Button(new Rect(460, 540, 175, 38), mageName))
        {
            currentPlayerName = mageName;
            currentPlayerHealth = mageHealth;
            currentPlayerAttack = mageAttack;
            currentPlayerDefense = mageDefense;
            currentPlayerStats = magePlayerStats;
        }

        if (GUI.Button(new Rect(670, 540, 175, 38), swordsmanName))
        {
            currentPlayerName = swordsmanName;
            currentPlayerHealth = swordsmanHealth;
            currentPlayerAttack = swordsmanAttack;
            currentPlayerDefense = swordsmanDefense;
            currentPlayerStats = swordsmanPlayerStats;
        }


        if (GUI.Button(new Rect(350, 260, 175, 38), "Attack Boss"))
        {
            damagedBossHealth = demonKingHealth - currentPlayerAttack;

            demonKingStats.SetHealthStat(damagedBossHealth);
            demonKingHealth = demonKingStats.DemonKingHealth; // I f hate that this solved 2 hours of my debugging

            currentBossStats = "Name: " + demonKingName + // like bro why the f do I have to copy paste this variable every time
                    "\nHealth: " + demonKingHealth +
                    "\nAttack: " + demonKingAttack +
                    "\nDefense: " + demonKingDefense; // I will spend my entire winter break solving this damn mystery

            if (demonKingHealth <= 0)
            {
                demonKingStats.SetHealthStat(0);
                demonKingHealth = demonKingStats.DemonKingHealth;

                currentBossStats = "Name: " + demonKingName +
                    "\nHealth: " + demonKingHealth +
                    "\nAttack: " + demonKingAttack +
                    "\nDefense: " + demonKingDefense;

                WinOrLoseText = "Players win!";
            }
        }

        if (GUI.Button(new Rect(575, 260, 175, 38), "Attack Players"))
        {
            damagedPlayerHealth = currentPlayerHealth - demonKingAttack;
            damagedKnightHealth = companionKnightHealth - demonKingAttack;

            companionKnightStats.SetHealthStat(damagedKnightHealth);
            companionKnightHealth = companionKnightStats.CompanionKnightHealth;

            companionKnightPlayerStats = "Name: " + companionKnightName +
                "\nHealth: " + companionKnightHealth +
                "\nAttack: " + companionKnightAttack +
                "\nDefense: " + companionKnightDefense;

            if (currentPlayerName == "Archer")
            {
                archerStats.SetHealthStat(damagedPlayerHealth);
                archerHealth = archerStats.ArcherHealth;

                currentPlayerHealth = archerHealth; // I am losing my shit

                currentPlayerStats = "Name: " + archerName + // DRY principle? I don't know her
                    "\nHealth: " + archerHealth +
                    "\nAttack: " + archerAttack +
                    "\nDefense: " + archerDefense;
            }
            else if (currentPlayerName == "Mage")
            {
                mageStats.SetHealthStat(damagedPlayerHealth);
                mageHealth = mageStats.MageHealth;

                currentPlayerHealth = mageHealth;

                currentPlayerStats = "Name: " + mageName +
                    "\nHealth: " + mageHealth +
                    "\nAttack: " + mageAttack +
                    "\nDefense: " + mageDefense;


            }
            else if (currentPlayerName == "Swordsman")
            {
                swordsmanStats.SetHealthStat(damagedPlayerHealth);
                swordsmanHealth = swordsmanStats.SwordsmanHealth;

                currentPlayerHealth = swordsmanHealth;

                currentPlayerStats = "Name: " + swordsmanName +
                    "\nHealth: " + swordsmanHealth +
                    "\nAttack: " + swordsmanAttack +
                    "\nDefense: " + swordsmanDefense;
            }

            if ((currentPlayerHealth <= 0) && (companionKnightHealth <= 0))
            {
                if (currentPlayerName == "Archer") // this is the worst spaghetti code I've written
                {
                    archerStats.SetHealthStat(0);
                    archerHealth = archerStats.ArcherHealth;

                    currentPlayerHealth = archerHealth;

                    currentPlayerStats = "Name: " + archerName +
                        "\nHealth: " + archerHealth +
                        "\nAttack: " + archerAttack +
                        "\nDefense: " + archerDefense;
                }
                else if (currentPlayerName == "Mage")
                {
                    mageStats.SetHealthStat(0);
                    mageHealth = mageStats.MageHealth;

                    currentPlayerHealth = mageHealth;

                    currentPlayerStats = "Name: " + mageName +
                        "\nHealth: " + mageHealth +
                        "\nAttack: " + mageAttack +
                        "\nDefense: " + mageDefense;
                }
                else if (currentPlayerName == "Swordsman")
                {
                    swordsmanStats.SetHealthStat(0);
                    swordsmanHealth = swordsmanStats.SwordsmanHealth;

                    currentPlayerHealth = swordsmanHealth;

                    currentPlayerStats = "Name: " + swordsmanName +
                        "\nHealth: " + swordsmanHealth +
                        "\nAttack: " + swordsmanAttack +
                        "\nDefense: " + swordsmanDefense; // it will be a nightmare to replace all the stats text
                }

                companionKnightStats.SetHealthStat(0);
                companionKnightHealth = companionKnightStats.CompanionKnightHealth;

                companionKnightPlayerStats = "Name: " + companionKnightName +
                    "\nHealth: " + companionKnightHealth +
                    "\nAttack: " + companionKnightAttack +
                    "\nDefense: " + companionKnightDefense;

                WinOrLoseText = "Players lost!";
            }
        }
    }
}

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

    private string WinOrLoseText = "you bitch";

    private string archerName;
    private int archerHealth;
    private int archerAttack;
    private int archerDefense;

    private string companionKnightName;
    private int companionKnightHealth;
    private int companionKnightAttack;
    private int companionKnightDefense;

    private string demonKingName;
    private int demonKingHealth;
    private int demonKingAttack;
    private int demonKingDefense;

    private string mageName;
    private int mageHealth;
    private int mageAttack;
    private int mageDefense;

    private string swordsmanName;
    private int swordsmanHealth;
    private int swordsmanAttack;
    private int swordsmanDefense;

    private string currentPlayerName;
    private int currentPlayerHealth;
    private int currentPlayerAttack;
    private int currentPlayerDefense;

    private string currentPlayerStats;
    private string companionKnightPlayerStats;
    private string archerPlayerStats;
    private string magePlayerStats;
    private string swordsmanPlayerStats;
    private string demonKingPlayerStats;

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

        position = new Vector2();
        size = new Vector2();
        position2 = new Vector2();
        size2 = new Vector2();
        position3 = new Vector2();
        size3 = new Vector2();

        currentPlayerName = "";
        currentPlayerHealth = 0;
        currentPlayerAttack = 0;
        currentPlayerDefense = 0;

        currentPlayerStats = "Name: " + currentPlayerName +
            "\nHealth: " + currentPlayerHealth +
            "\nAttack: " + currentPlayerAttack +
            "\nDefense: " + currentPlayerDefense;

        archerName = archerStats.ArcherName;
        archerHealth = archerStats.ArcherHealth;
        archerAttack = archerStats.ArcherAttack;
        archerDefense = archerStats.ArcherDefense;

        companionKnightName = companionKnightStats.CompanionKnightName;
        companionKnightHealth = companionKnightStats.CompanionKnightHealth;
        companionKnightAttack = companionKnightStats.CompanionKnightAttack;
        companionKnightDefense = companionKnightStats.CompanionKnightDefense;

        demonKingName = demonKingStats.DemonKingName;
        demonKingHealth = demonKingStats.DemonKingHealth;
        demonKingAttack = demonKingStats.DemonKingAttack;
        demonKingDefense = demonKingStats.DemonKingDefense;

        mageName = mageStats.MageName;
        mageHealth = mageStats.MageHealth;
        mageAttack = mageStats.MageAttack;
        mageDefense = mageStats.MageDefense;

        swordsmanName = swordsmanStats.SwordsmanName;
        swordsmanHealth = swordsmanStats.SwordsmanHealth;
        swordsmanAttack = swordsmanStats.SwordsmanAttack;
        swordsmanDefense = swordsmanStats.SwordsmanDefense;
    }


    public void ReferenceStats() // check if this is necessary
    {
        archerName = archerStats.ArcherName;
        archerHealth = archerStats.ArcherHealth;
        archerAttack = archerStats.ArcherAttack;
        archerDefense = archerStats.ArcherDefense;

        companionKnightName = companionKnightStats.CompanionKnightName;
        companionKnightHealth = companionKnightStats.CompanionKnightHealth;
        companionKnightAttack = companionKnightStats.CompanionKnightAttack;
        companionKnightDefense = companionKnightStats.CompanionKnightDefense;

        demonKingName = demonKingStats.DemonKingName;
        demonKingHealth = demonKingStats.DemonKingHealth;
        demonKingAttack = demonKingStats.DemonKingAttack;
        demonKingDefense = demonKingStats.DemonKingDefense;

        mageName = mageStats.MageName;
        mageHealth = mageStats.MageHealth;
        mageAttack = mageStats.MageAttack;
        mageDefense = mageStats.MageDefense;

        swordsmanName = swordsmanStats.SwordsmanName;
        swordsmanHealth = swordsmanStats.SwordsmanHealth;
        swordsmanAttack = swordsmanStats.SwordsmanAttack;
        swordsmanDefense = swordsmanStats.SwordsmanDefense;

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
    }

    private void OnGUI()
    {
        ReferenceStats();


        GUI.Box(new Rect(10, 10, 1080, 600), ""); // Screen box

        GUI.Label(new Rect(520, 30, 100, 100), WinOrLoseText); // Win or Lose text

        GUI.Box(new Rect(350, 75, 400, 175), demonKingPlayerStats); // Boss stats

        GUI.Box(new Rect(130, 325, 400, 175), currentPlayerStats); // Current player stats

        GUI.Box(new Rect(580, 325, 400, 175), companionKnightPlayerStats); // Companion Knight stats


        if (GUI.Button(new Rect(250, 540, 175, 38), archerName))
        {
            currentPlayerStats = archerPlayerStats;
        }

        if (GUI.Button(new Rect(460, 540, 175, 38), mageName))
        {
            currentPlayerStats = magePlayerStats;
        }

        if (GUI.Button(new Rect(670, 540, 175, 38), swordsmanName))
        {
            currentPlayerStats = swordsmanPlayerStats;
        }


        if (GUI.Button(new Rect(350, 260, 175, 38), "Attack Boss"))
        {
            if (demonKingHealth > 0)
            {
                demonKingHealth -= currentPlayerAttack + companionKnightAttack;
                GUI.Box(new Rect(350, 75, 400, 175), demonKingPlayerStats); // Boss stats

                print("why are you gay?");
            }
        }

        if (GUI.Button(new Rect(575, 260, 175, 38), "Attack Players"))
        {

        }

        //GUI.Box(new Rect(position, size), "");

        //GUI.Button(new Rect(position, size), text);

        //if (GUI.Button(new Rect(position, size), text)) { }
    }
}

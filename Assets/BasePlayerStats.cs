using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerStats : MonoBehaviour
{
    protected static string Name(string x) // Abstraction using protected keyword
    {
        return x;
    }

    protected static int Health(int x)
    {
        return x;
    }

    protected static int Attack(int x)
    {
        return x;
    }

    protected static int Defense(int x)
    {
        return x;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public enum Achievement
{
    Seed,
    Corn,
    Potatoes,
    Tomato,
    Watermelon,
    withered,
}

public class FarmEngine : MonoBehaviour
{ 
    [SerializeField] private Achievement achievement;
    [SerializeField] private bool growth = false;
    [SerializeField] private bool rotten = false;
    [SerializeField] private int maxDegreeOfGrowth = 10;
    
    private int _degreeOfGrowth = 0;

    private void Init()
    {
        growth = false;
        rotten = false;
        _degreeOfGrowth = 0;
    }

    private void Update()
    {
        throw new NotImplementedException();
    }

    public Achievement Harvest()
    {
        if (growth)
        {
            return achievement;
            Init();
        }
        else
        {
            achievement = Achievement.Seed;
        }
    
        return achievement;
    }

    public void Destruction()
    {
        if (rotten)
        {
            achievement = Achievement.withered;
            Init();
        }
        else
        {
            achievement = Achievement.Seed;
        }
    }
    
}

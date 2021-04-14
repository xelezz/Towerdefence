using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int currentHP;
    public int maxHp;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HP(int hpAmounth)
    {
        currentHP += hpAmounth;
        if (currentHP > maxHp)
        {
            currentHP = maxHp;
        }

    }

    public void HurtEnemy(int damage)
    {
        currentHP += damage;
    }
}

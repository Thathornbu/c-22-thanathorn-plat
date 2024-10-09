using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Weapon : MonoBehaviour
{
    [SerializeField] private int damage;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    private string owner;

    abstract public void OnHitWith(Character Name);
    abstract public void Move();
    public int GetShootDirection()  
    {
        return 1;
    }
    

}
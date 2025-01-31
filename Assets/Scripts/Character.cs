using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] public int health;
    public int Health
    {
        get
        {
            return Health;
        }
        set
        {
            health = value;
        }
    }

        public Animator anim;
        public Rigidbody2D rb;

    public bool Isdead()
    {
       return Health <= 0;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}

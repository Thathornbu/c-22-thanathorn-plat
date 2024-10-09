using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] private float speed;
    
    private void Start()
    {
        //ค่า dm และความเร็วตามที่กำหนด
        Move();
        Damage = 30;
        speed = 4;
    }

    public override void OnHitWith(Character Name)
    {
       
    }
    public override void Move()
    {
        Debug.Log("Banana moves with constsant speed using Transform");
    }
}

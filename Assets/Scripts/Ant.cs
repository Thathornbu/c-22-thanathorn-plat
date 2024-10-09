using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] Vector2 valocity;
    [SerializeField] private Transform[] movePoints;

    /*public void Initialize(int newHealith) 
    {
        Health = newHealith;
    }*/

    private void FixedUpdate()
    {
        Behavior();   
    }

    public override void Behavior()
    {
        rb.MovePosition(rb.position + valocity * Time.fixedDeltaTime);

        if (rb.position.x <= movePoints[0].position.x && valocity.x < 0)
        {
            FlipCharacter();
        }
        else if (rb.position.x >= movePoints[0].position.x && valocity.x > 0)
        {
            FlipCharacter();
        }


    }

    private void FlipCharacter()
    {
        valocity *= -1;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}

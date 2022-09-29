using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public LayerMask layer;
    ControlActor actor;

    public Collider2D[] collideTab;
    private void Start()
    {
        actor = transform.parent.GetComponent<ControlActor>();
    }
    private void Update()
    {
        actor.isGrounded = Physics2D.OverlapCircle(transform.position, 0.1f, layer);
        
    }
}

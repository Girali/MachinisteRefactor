using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlActor : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce = 10;
    public ConveyorBelt conveyor;

    public bool isJumping = false;
    public bool isGrounded = false;
    public bool isFalling = false;
    bool isInvincible = false;

    public MoveCode typeMouvement;

    bool biHasWaited = false;
    bool biIsWaiting = false;
    public float biWaitTime = 4f;
    float biCurrentTime = 0;
    public int biNbJumps = 1;
    int biJumpsDone = 0;
    public QuestManager.questTaking questTaking;

    public float radDistance = 2f;
    SeeField seefield;

    public int numberBlinks = 6;

    Animator animator;
    public Animator machiniste;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        seefield = GetComponentInChildren<SeeField>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isJumping && rb.velocity.y < 0)
        {
            isJumping = false;
            if (isGrounded)
            {
                isFalling = false;
            } else
            {
                isFalling = true;
            }
            
        }
        if(isFalling && isGrounded)
        {
            isFalling = false;
        }
        if(isGrounded && rb.velocity.y <= 0)
        {
            isJumping = false;
        }


        if(typeMouvement == MoveCode.Lapin)
        {
            lapinMove();
        }
        if(typeMouvement == MoveCode.Biphase)
        {
            StartCoroutine("BiphaseMove");
        }
        if(typeMouvement == MoveCode.Radar)
        {
            radarMove();
        }

        if(biIsWaiting)
        {
            if (!conveyor.isPaused)
            {
                biCurrentTime += Time.deltaTime;
                if(biCurrentTime >= biWaitTime)
                {
                    biHasWaited = true;
                }
            }
        }
        animator.SetBool("grounded", isGrounded);
        animator.SetBool("conveyorIsMoving", ConveyorBelt.TapisRoulantVitesseActuelle > 0);
    }

    public enum MoveCode
    {
        None = -1,
        Lapin = 0,
        Biphase = 1,
        Radar = 2
    }

    private void lapinMove()
    {
        if (isGrounded && !isJumping)
        {
            Jump(jumpForce);
        }
    }
    private void BiphaseMove()
    {
        if (biHasWaited && isGrounded && !isJumping && biJumpsDone<=biNbJumps && !conveyor.isPaused)
        {
            Jump(jumpForce);
            biJumpsDone++;
            if (biJumpsDone >= biNbJumps)
            {
                biHasWaited = false;
                biIsWaiting = false;
                biJumpsDone = 0;
            }

        } else
        {
            if(!biIsWaiting)
            {
                biCurrentTime = 0;
                biIsWaiting = true;
            }
        }
    }
    private void radarMove()
    {
        if(isGrounded && !isJumping)
        {
            foreach (Transform t in seefield.seenObjects)
            {
                if(t != null)
                {
                    if (t.gameObject.tag == "Brick")
                    {
                        float dist =  transform.position.x - t.position.x;
                        if (dist <= radDistance && dist > 0)
                        {
                            Jump(jumpForce);
                        }
                    }
                }
            }
        }
        
    }
    public void Jump(float force)
    {
        machiniste.SetTrigger("Jump");
        isJumping = true;
        isFalling = false;
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
    }

    public bool Invincible()
    {
        return isInvincible;
    }

    public IEnumerator HitBlink()
    {
        isInvincible = true;
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        SpriteRenderer ropeSprite = new SpriteRenderer();
        foreach (Transform child in transform)
        {
            if(child.GetComponent<SpriteRenderer>() != null)
            {
                ropeSprite = child.GetComponent<SpriteRenderer>();
            }
        }
        for (int i=0; i < numberBlinks; i++)
        {
            sprite.enabled = false;
            ropeSprite.enabled = false;
            yield return new WaitForSeconds(0.2f);
            sprite.enabled = true;
            ropeSprite.enabled = true;
            yield return new WaitForSeconds(0.2f);
        }
        isInvincible = false;
    }
}

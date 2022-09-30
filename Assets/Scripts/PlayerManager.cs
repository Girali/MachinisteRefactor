using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{
    public class PlayerManager : MonoBehaviour
    {
        private Rigidbody2D rb;

        private bool grounded = true;

        private float jumpForce = 7;
        private float autoJumpDelayDistance = 0.3f;
        private float lastJumpdDistance = 0f;
        private float IFrameTime = 0f;
        private float IFrameDuration = 2f;
        private bool immune = false;

        private MoveSet currentMoveSet = MoveSet.None;

        private Animator animator;

        public SpriteRenderer render;
        public SpriteRenderer rope;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            InitMoveSet(MoveSet.JumpWaitJump);
        }

        public void StopStartWalk(bool b)
        {
            animator.SetBool("Walking", b);
        }

        public void GetHit(TriggerTrigger c)
        {
            SceneObject s = c.data.GetComponent<SceneObject>();

            if (s)
            {
                if(s.type == SceneObjectType.Ennemy)
                {
                    if (!immune)
                    {
                        immune = true;
                        EventGameController.Instance.playerGetHit();
                        IFrameTime = GameController.Instance.distanceDone + IFrameDuration;
                        StartCoroutine(GetHitCRT());
                    }
                }
                else if (s.type == SceneObjectType.Flag)
                {
                    EventGameController.Instance.playerGetFlag();
                }
            }
        }

        IEnumerator GetHitCRT()
        {
            render.enabled = false;
            rope.enabled = false;
            yield return new WaitForSeconds(0.3f);
            render.enabled = true;
            rope.enabled = true;
            yield return new WaitForSeconds(0.3f);
            render.enabled = false;
            rope.enabled = false;
            yield return new WaitForSeconds(0.3f);
            render.enabled = true;
            rope.enabled = true;
            yield return new WaitForSeconds(0.3f);
            render.enabled = false;
            rope.enabled = false;
            yield return new WaitForSeconds(0.3f);
            render.enabled = true;
            rope.enabled = true;
        }

        private float nextHeightCheck = 0;
        private float hieghtCheckDistance = 5;

        public void PlayerReset()
        {
            grounded = true;
            lastJumpdDistance = 0f;
            IFrameTime = 0f;
            immune = false;
            nextJumpDistance = 0;
            moveSetCounter = 0;
            jumpStored = false;
        }

        public void Move(float frameDistance)
        {
            if(GameController.Instance.distanceDone > nextHeightCheck)
            {
                nextHeightCheck = GameController.Instance.distanceDone + hieghtCheckDistance;
                EventGameController.Instance.playerHeightCheck();
            }

            if(immune && IFrameTime < GameController.Instance.distanceDone)
            {
                immune = false;
            }

            switch (currentMoveSet)
            {
                case MoveSet.JumpWait:
                    MoveSet1();
                    break;
                case MoveSet.JumpWaitJump:
                    MoveSet2();
                    break;
                case MoveSet.JumpWaitJumpJump:
                    MoveSet3();
                    break;
                default:
                    break;
            }
        }

        private void FixedUpdate()
        {
            //if (rb.velocity.y < 0)
            //    rb.velocity += new Vector2(0, Physics2D.gravity.y * Time.fixedDeltaTime) * 1.5f;
            //else if (rb.velocity.y > 0)
            //    rb.velocity += new Vector2(0, Physics2D.gravity.y * Time.fixedDeltaTime) * 0.8f;

            if (!grounded)
            { 
                if (lastJumpdDistance + autoJumpDelayDistance < GameController.Instance.distanceDone || GameController.Instance.stucked)
                {
                    Debug.DrawRay(transform.position, Vector3.down * 0.6f, Color.red);
                    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.6f);

                    if (hit.collider != null)
                    {
                        grounded = true;

                        SceneObject s = hit.collider.GetComponent<SceneObject>();

                        if(s == null)
                            EventGameController.Instance.playerGetGrounded();
                        else if(s.type == SceneObjectType.Block)
                            EventGameController.Instance.playerJumpOnBlock();

                        animator.SetBool("Grounded", grounded);
                    }
                }
            }
        }

        private void Update()
        {
            Debug.DrawRay(transform.position, Vector3.left * 0.6f, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, 0.6f);

            if (hit.collider != null)
            {
                SceneObject s = hit.collider.GetComponent<SceneObject>();

                if (s != null && s.type == SceneObjectType.Block)
                {
                    if (grounded)
                    {
                        Jump();
                    }

                    GameController.Instance.Stuck();
                    animator.SetBool("Walking", false);
                }
            }
            else
            {
                GameController.Instance.Unstuck();
                animator.SetBool("Walking", true);
            }
        }

        public void Jump()
        {
            if (grounded && !GameController.Instance.stucked)
            {
                grounded = false;
                rb.velocity = Vector3.zero;
                animator.SetBool("Grounded", grounded);
                rb.velocity += new Vector2(0, jumpForce);
                lastJumpdDistance = GameController.Instance.distanceDone;
            }
        }

        public void Bounce()
        {
            grounded = false;
            rb.velocity = Vector3.zero;
            animator.SetBool("Grounded", grounded);
            rb.velocity += new Vector2(0, jumpForce * 0.75f);
            lastJumpdDistance = GameController.Instance.distanceDone;
        }

        public void InitMoveSet(MoveSet m)
        {
            currentMoveSet = m;

            moveSetCounter = 0;

            switch (m)
            {
                case MoveSet.JumpWait:
                    nextJumpDistance = GameController.Instance.distanceDone + 5;
                    break;
                case MoveSet.JumpWaitJump:
                    nextJumpDistance = GameController.Instance.distanceDone + 5;
                    break;
                case MoveSet.JumpWaitJumpJump:
                    break;
                default:
                    break;
            }
        }

        float nextJumpDistance = 0;
        int moveSetCounter = 0;
        bool jumpStored = false;

        public bool Grounded { get => grounded; }

        private void MoveSet1()
        {
            if(GameController.Instance.distanceDone > nextJumpDistance && nextJumpDistance != 0)
            {
                nextJumpDistance = GameController.Instance.distanceDone + 5 - (GameController.Instance.TimeStep * 3f);

                if (grounded)
                    Jump();
                else
                    jumpStored = true;
            }

            if(jumpStored && grounded)
            {
                Jump();
            }
        }

        private void MoveSet2()
        {

            if (GameController.Instance.distanceDone > nextJumpDistance && nextJumpDistance != 0)
            {
                switch (moveSetCounter)
                {
                    case 0:
                        nextJumpDistance = GameController.Instance.distanceDone + 1 - (GameController.Instance.TimeStep * 3f);
                        moveSetCounter = 1;
                        break;
                    case 1:
                        nextJumpDistance = GameController.Instance.distanceDone + 5 - (GameController.Instance.TimeStep * 3f);
                        moveSetCounter = 0;
                        break;
                    default:
                        break;
                }

                if (grounded)
                    Jump();
                else
                    jumpStored = true;
            }
        }

        private void MoveSet3()
        {
            if (GameController.Instance.distanceDone > nextJumpDistance && nextJumpDistance != 0)
            {
                switch (moveSetCounter)
                {
                    case 0:
                        nextJumpDistance = GameController.Instance.distanceDone + 1 - (GameController.Instance.TimeStep * 3f);
                        moveSetCounter = 1;
                        break;
                    case 1:
                        nextJumpDistance = GameController.Instance.distanceDone + 1 - (GameController.Instance.TimeStep * 3f);
                        moveSetCounter = 2;
                        break;
                    case 2:
                        nextJumpDistance = GameController.Instance.distanceDone + 5 - (GameController.Instance.TimeStep * 3f);
                        moveSetCounter = 0;
                        break;
                    default:
                        break;
                }

                if (grounded)
                    Jump();
                else
                    jumpStored = true;
            }
        }

        public enum MoveSet
        {
            None,
            JumpWait,
            JumpWaitJump,
            JumpWaitJumpJump
        }
    }
}

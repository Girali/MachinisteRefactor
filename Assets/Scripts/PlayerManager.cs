using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{
    public class PlayerManager : MonoBehaviour
    {
        private Rigidbody2D rb;

        private float distanceDone = 0;
        private float lastDistance = 0;
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

            if (s && s.type == SceneObjectType.Ennemy)
            {
                if (!immune)
                {
                    immune = true;
                    IFrameTime = distanceDone + IFrameDuration;
                    StartCoroutine(GetHitCRT());
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

        public void Move(float frameDistance)
        {
            lastDistance = distanceDone;
            distanceDone += frameDistance;

            if(immune && IFrameTime < distanceDone)
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
            if (rb.velocity.y < 0)
                rb.velocity += new Vector2(0, Physics2D.gravity.y * Time.fixedDeltaTime) * 1.5f;
            else if (rb.velocity.y > 0)
                rb.velocity += new Vector2(0, Physics2D.gravity.y * Time.fixedDeltaTime) * 0.8f;

            if (!grounded)
            { 
                if (lastJumpdDistance + autoJumpDelayDistance < distanceDone)
                {
                    Debug.DrawRay(transform.position, Vector3.down * 0.6f, Color.red);
                    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.6f);

                    if (hit.collider != null)
                    {
                        grounded = true;
                        animator.SetBool("Grounded", grounded);
                    }
                }
            }
        }

        private void Update()
        {
            if (grounded)
            {
                Debug.DrawRay(transform.position, Vector3.left * 0.6f, Color.red);
                RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, 0.6f);

                if (hit.collider != null)
                {
                    SceneObject s = hit.collider.GetComponent<SceneObject>();
                    if (s != null && s.type == SceneObjectType.Block)
                    {
                        Jump();
                    }
                }
            }
        }

        public void Jump()
        {
            grounded = false;
            rb.velocity = Vector3.zero;
            animator.SetBool("Grounded", grounded);
            rb.velocity += new Vector2(0, jumpForce);
            lastJumpdDistance = distanceDone;
        }

        public void InitMoveSet(MoveSet m)
        {
            currentMoveSet = m;

            moveSetCounter = 0;

            switch (m)
            {
                case MoveSet.JumpWait:
                    nextJumpDistance = distanceDone + 5;
                    break;
                case MoveSet.JumpWaitJump:
                    nextJumpDistance = distanceDone + 5;
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
            if(distanceDone > nextJumpDistance )
            {
                nextJumpDistance = distanceDone + 5 - (GameController.Instance.TimeStep * 3f);

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
            if (distanceDone > nextJumpDistance)
            {
                switch (moveSetCounter)
                {
                    case 0:
                        nextJumpDistance = distanceDone + 1 - (GameController.Instance.TimeStep * 3f);
                        moveSetCounter = 1;
                        break;
                    case 1:
                        nextJumpDistance = distanceDone + 5 - (GameController.Instance.TimeStep * 3f);
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
            if (distanceDone > nextJumpDistance)
            {
                switch (moveSetCounter)
                {
                    case 0:
                        nextJumpDistance = distanceDone + 1 - (GameController.Instance.TimeStep * 3f);
                        moveSetCounter = 1;
                        break;
                    case 1:
                        nextJumpDistance = distanceDone + 1 - (GameController.Instance.TimeStep * 3f);
                        moveSetCounter = 2;
                        break;
                    case 2:
                        nextJumpDistance = distanceDone + 5 - (GameController.Instance.TimeStep * 3f);
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

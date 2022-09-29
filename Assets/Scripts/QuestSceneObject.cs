using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{
    public class QuestSceneObject : SceneObject
    {
        private bool taken = false;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            cldr.isTrigger = true;
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }

        protected override void OnTriggerEnter2D(Collider2D collision)
        {
            base.OnTriggerEnter2D(collision);
            if (inScene)
            {
                if (collision.tag == "Player")
                {
                    if(taken == false)
                    {
                        taken = true;
                    }
                }
            }
        }
    }
}

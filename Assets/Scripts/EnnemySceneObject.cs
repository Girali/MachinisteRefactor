using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{
    public class EnnemySceneObject : SceneObject
    {
        private bool dead = false;
        public GameObject alive;
        public GameObject death;

        public void Death()
        {
            dead = true;
            cldr.isTrigger = true;
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            alive.SetActive(false);
            death.SetActive(true);
        }

        public void OnTrigger(TriggerTrigger t)
        {
            if (inScene)
            {
                if (t.data.tag == "Player")
                {
                    if (dead == false)
                    {
                        Rigidbody2D r = t.data.attachedRigidbody;
                        if (r.velocity.y < 0)
                        {
                            PlayerManager pm = r.GetComponent<PlayerManager>();

                            if (!pm.Grounded)
                            {
                                Death();
                                pm.Jump();
                            }
                        }
                    }
                }
            }
        }
    }
}

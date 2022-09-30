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
            cldr.enabled = false;
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            alive.SetActive(false);
            death.SetActive(true);
            EventGameController.Instance.playerKillEnnemy();
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
                        if (r.transform.position.y - transform.position.y > 0)
                        {
                            PlayerManager pm = r.GetComponent<PlayerManager>();

                            //if (!pm.Grounded)
                            {
                                
                                Death();
                                pm.Bounce();
                            }
                        }
                    }
                }
            }
        }
    }
}

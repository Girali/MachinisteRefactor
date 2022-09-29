using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{
    public class ChestSceneObject : SceneObject
    {
        public GameObject open;
        public GameObject close;

        private bool opened = false;

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
                    if (opened == false)
                    {
                        opened = true;
                        open.SetActive(false);
                        close.SetActive(true);
                    }
                }
            }
        }
    }
}

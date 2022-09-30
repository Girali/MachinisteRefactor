using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{
    public class SceneObject : MonoBehaviour
    {
        protected Rigidbody2D rb;
        protected Collider2D cldr;
        protected bool grabbed = false;
        public bool insideDropZone = false;
        public SceneObjectType type;
        public bool snapToGrid;

        protected bool inScene = false;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            cldr = GetComponent<Collider2D>();
        }

        public void Grab()
        {
            grabbed = true;
        }

        public void GetInScene()
        {
            inScene = true;
            cldr.isTrigger = false;
            insideDropZone = false;
            grabbed = false;
            gameObject.layer = LayerMask.GetMask("Default");

            switch (type)
            {
                case SceneObjectType.Block:
                    //rb.bodyType = RigidbodyType2D.Dynamic;
                    //rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    break;
                case SceneObjectType.Ennemy:
                    rb.bodyType = RigidbodyType2D.Dynamic;
                    rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
                    break;
                case SceneObjectType.Chest:
                    rb.bodyType = RigidbodyType2D.Dynamic;
                    rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
                    break;
                case SceneObjectType.Quest:
                    rb.bodyType = RigidbodyType2D.Dynamic;
                    rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
                    break;
                default:
                    break;
            }
        }

        public void GetOutScene()
        {
            if (inScene)
            {
                gameObject.layer = 5;
                inScene = false;
                rb.constraints = RigidbodyConstraints2D.None;
                rb.bodyType = RigidbodyType2D.Dynamic;

                Destroy(gameObject, 4f);
            }
        }

        protected virtual void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "DropZone")
            {
                insideDropZone = true;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag == "DropZone")
            {
                insideDropZone = false;
            }
        }
    }

    public enum SceneObjectType
    {
        Block,
        Ennemy,
        Chest,
        Quest,
        Flag
    }
}

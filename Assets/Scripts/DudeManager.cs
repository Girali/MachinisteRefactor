using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{

    public class DudeManager : MonoBehaviour
    {
        private int indexType = 0;

        public Jun_TweenRuntime fadeEye;
        public Jun_TweenRuntime fadeFace;

        public Jun_TweenRuntime happy;
        public Jun_TweenRuntime sad;

        public SpriteRenderer faceOk;
        public SpriteRenderer faceFrustrated;
        public SpriteRenderer faceBored;

        public Sprite[] spritesOk;
        public Sprite[] spritesFrustrated;
        public Sprite[] spritesBored;

        private bool gone = true;

        public void Init()
        {
            if (gone)
            {
                gone = false;
                fadeEye.Play();
                fadeFace.Play();

                int i = Random.Range(0, spritesOk.Length);

                while (i == indexType)
                {
                    i = Random.Range(0, spritesOk.Length);
                }

                indexType = i;

                faceOk.sprite = spritesOk[i];
                faceFrustrated.sprite = spritesFrustrated[i];
                faceBored.sprite = spritesBored[i];
            }
        }

        public void Gone()
        {
            if (!gone)
            {
                gone = true;
                faceOk.gameObject.SetActive(true);
                faceFrustrated.gameObject.SetActive(false);
                faceBored.gameObject.SetActive(false);

                fadeEye.Rewind();
                fadeFace.Rewind();

                if(!GameController.Instance.waitForDialogueEnd)
                    StartCoroutine(GoneCRT());
            }
        }

        private IEnumerator GoneCRT()
        {
            yield return new WaitForSeconds(1f);
            EventGameController.Instance.dudeGone();
        }

        public void Move(float f, float b)
        {
            if (!gone)
            {
                if (f > 50)
                {
                    if (!faceFrustrated.gameObject.activeSelf)
                    {
                        faceOk.gameObject.SetActive(false);
                        faceFrustrated.gameObject.SetActive(true);
                        faceBored.gameObject.SetActive(false);
                    }
                }
                else if (b > 50)
                {
                    if (!faceBored.gameObject.activeSelf)
                    {
                        faceOk.gameObject.SetActive(false);
                        faceFrustrated.gameObject.SetActive(false);
                        faceBored.gameObject.SetActive(true);
                    }
                }
                else
                {
                    if (!faceOk.gameObject.activeSelf)
                    {
                        faceOk.gameObject.SetActive(true);
                        faceFrustrated.gameObject.SetActive(false);
                        faceBored.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}

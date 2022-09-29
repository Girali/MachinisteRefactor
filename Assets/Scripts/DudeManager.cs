using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeManager : MonoBehaviour
{
    private int indexType = 0;

    public Jun_TweenRuntime fadeEye;
    public Jun_TweenRuntime fadeFace;

    public SpriteRenderer faceOk;
    public SpriteRenderer faceFrustrated;
    public SpriteRenderer faceBored;

    public Sprite[] spritesOk;
    public Sprite[] spritesFrustrated;
    public Sprite[] spritesBored;

    public void Init()
    {
        fadeEye.Play();
        fadeFace.Play();

        int i = Random.Range(0, spritesOk.Length);

        while (i == indexType)
        {
            i = Random.Range(0, spritesOk.Length);
        }

        faceOk.sprite = spritesOk[i];
        faceFrustrated.sprite = spritesFrustrated[i];
        faceBored.sprite = spritesBored[i];
    }

    public void Move(float f, float b)
    {
        
    }
}

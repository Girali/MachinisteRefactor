using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFreeze : MonoBehaviour
{
    public IEnumerator freeze()
    {
        yield return new WaitForSeconds(0.05f);
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
    }
}

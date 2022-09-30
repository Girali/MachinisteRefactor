using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryController : MonoBehaviour
{
    IEnumerator Start()
    {

        yield return new WaitForSeconds(1f);
        DialogueManageur.Instance.ReceptionDialogue(300101);
    }
}

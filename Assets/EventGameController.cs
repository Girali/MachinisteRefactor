using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventGameController : MonoBehaviour
{

    private static EventGameController _instance;
    public static EventGameController Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<EventGameController>();

            return _instance;
        }
    }

    public UnityAction playerGetHit;
    public UnityAction playerGetGrounded;
    public UnityAction playerGetFlag;
    public UnityAction playerJumpOnBlock;
    public UnityAction playerHeightCheck;
    public UnityAction playerOpenChest;
    public UnityAction playerKillEnnemy;

    public UnityAction dudeBoringCycle;
    public UnityAction dudeGone;
}

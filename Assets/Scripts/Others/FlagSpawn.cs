using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagSpawn : MonoBehaviour
{
    public GameObject flag1;
    public GameObject flag2;
    public GameObject flag3;

    public TargetManager TM;
    public ConveyorBelt Conveyor;

    public bool flag1Spawn = false;
    public bool flag2Spawn = false;
    public bool flag3Spawn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!flag1Spawn)
        {
            if (TM.timeSpent > TM.timeToValidateStage1 - 0.1f && TM.timeSpent < TM.timeToValidateStage1 + 0.1f)
            {
                Instantiate(flag1, transform.position, transform.rotation, Conveyor.transform);
                flag1Spawn = true;
            }
        }
        if (!flag2Spawn)
        {
            if (TM.timeSpent > TM.timeToValidateStage2 - 0.1f && TM.timeSpent < TM.timeToValidateStage2 + 0.1f)
            {
                Instantiate(flag2, transform.position, transform.rotation, Conveyor.transform);
                flag2Spawn = true;
            }
        }
        if (!flag3Spawn)
        {
            if (TM.timeSpent > TM.timeToValidateStage3 - 0.1f && TM.timeSpent < TM.timeToValidateStage3 + 0.1f)
            {
                Instantiate(flag3, transform.position, transform.rotation, Conveyor.transform);
                flag3Spawn = true;
            }
        }


    }
}

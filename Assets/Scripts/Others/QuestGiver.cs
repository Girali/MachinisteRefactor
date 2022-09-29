using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestGiver : MonoBehaviour
{
    public int objectiveNumber;
    public QuestType objectiveType;
    public bool questGiven = false;

    public GameObject questBubble;
    public GameObject bubble;

    private void Start()
    {
        CreateQuest();
    }
    public enum QuestType
    {
        Kill = 0,
        Collect = 1
    }

    public void CreateQuest()
    {
        objectiveNumber = Random.Range(3, 7);
        objectiveType = (QuestType)Random.Range(0, 2);
        bubble = Instantiate(questBubble, GameObject.Find("Canvas - World").transform);
        bubble.transform.position = new Vector2(transform.position.x +0.4f, transform.position.y + 0.8f);
        bubble.GetComponentInChildren<TextMeshProUGUI>().text = ""+objectiveNumber;
        bubble.GetComponent<Animator>().SetBool("isKill", objectiveType==QuestType.Kill);
    }

    private void Update()
    {
        bubble.transform.position = transform.position + transform.TransformDirection(new Vector3(0.4f, 0.8f,0.1f));
        bubble.transform.rotation = transform.rotation;
    }
}

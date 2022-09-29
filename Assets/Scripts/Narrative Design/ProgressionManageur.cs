using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionManageur : MonoBehaviour
{
    public static ProgressionManageur PM;

    public int PallierDeJeu = 11;

    public int NbConversationsSTNPDites = 0;

    public GameObject PremierPersoApparition;

    public GameObject BrickSlot1;
    public GameObject BrickSlot2;
    public GameObject BrickSlot3;
    public GameObject BrickSlot4;

    public GameObject Icone1;
    public GameObject Icone2;
    public GameObject Icone3;
    public GameObject Icone4;

    public GameObject DropZone1;
    public GameObject DropZone2;
    public GameObject DropPanel;
    public float endPanelY;
    //private bool canDrop = false;

    private IEnumerator coroutine;
    void Awake()
    {
        if (PM == null)
        {
            PM = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        coroutine = LancementPremierDialogue();
        StartCoroutine(coroutine);

        

        Icone1.SetActive(false);
        Icone2.SetActive(false);
        Icone3.SetActive(false);
        Icone4.SetActive(false);
        DropZone2.SetActive(false);


        if (PremierPersoApparition != null)
        {
           PremierPersoApparition.SetActive(false);
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            PallierDeJeu++;
            Changementpallier();
        }

        if(Input.GetKeyDown(KeyCode.O))
        {
            OpenBoxes2();
        }

    }

    private IEnumerator LancementPremierDialogue()
    {
        yield return new WaitForSeconds(1);
        DialogueManageur.Instance.ReceptionDialogue(300101);
    }

    private void Changementpallier()
    {
        if (PallierDeJeu == 12)
        {
            DialogueManageur.Instance.ReceptionDialogue(300301);
        }

        if (PallierDeJeu == 13)
        {
            DialogueManageur.Instance.ReceptionDialogue(300401);
        }
    }

    public void OpenBoxes1()
    {
        PM.Icone1.SetActive(true);
        PM.Icone2.SetActive(true);
        BrickSlot1.GetComponent<Animator>().SetBool("open", true);
        BrickSlot2.GetComponent<Animator>().SetBool("open", true);
        BrickSlot1.GetComponent<DragDrop>().closed = false;
        BrickSlot2.GetComponent<DragDrop>().closed = false;
    }

    public void OpenBoxes2()
    {
        PM.Icone3.SetActive(true);
        BrickSlot3.GetComponent<Animator>().SetBool("open", true);
        BrickSlot3.GetComponent<DragDrop>().closed = false;
    }

    public void OpenBoxes3()
    {
        PM.Icone4.SetActive(true);
        BrickSlot4.GetComponent<Animator>().SetBool("open", true);
        BrickSlot4.GetComponent<DragDrop>().closed = false;
    }

    public IEnumerator RemoveDropZone()
    {
        Debug.Log("RemoveDropZone");
        DropZone2.SetActive(true);
        DropZone1.SetActive(false);
        while(DropPanel.transform.position.y < endPanelY)
        {
            DropPanel.transform.position = Vector3.MoveTowards(DropPanel.transform.position, new Vector3(DropPanel.transform.position.x, endPanelY, DropPanel.transform.position.z), 0.01f);
            yield return new WaitForEndOfFrame();
        }
        
    }
}

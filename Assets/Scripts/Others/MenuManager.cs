using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject rope;
    public bool hasClickedPlay = false;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ClickPlay()
    {
        if(!hasClickedPlay)
        {
            hasClickedPlay = true;
            DialogueManageur.Instance.ReceptionDialogue(306801);
        }
        else
        {
            DialogueManageur.Instance.ReceptionDialogue(306901);
        }
    }

    public void ClicSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SD/Clic");
    }
}

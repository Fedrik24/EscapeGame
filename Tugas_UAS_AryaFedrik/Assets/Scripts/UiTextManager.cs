using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiTextManager : MonoBehaviour
{
    public GameObject TutorialPanel;
    public GameObject TutorialBox;

    private void Start()
    {
        TutorialPanel.SetActive(false);
        TutorialBox.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(UiCouruntine());
        }
    }

    IEnumerator UiCouruntine()
    {
        TutorialPanel.SetActive(true);
        TutorialBox.SetActive(true);
        yield return new WaitForSeconds(3);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            TutorialPanel.SetActive(false);
            TutorialBox.SetActive(false);
        }
    }
}

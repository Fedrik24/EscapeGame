using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpTrigger : MonoBehaviour
{
    public GameObject Player;
    public GameObject mCam;
    public GameObject jumpCam;
    public AudioSource JumpScare;
    public GameObject DiePanel;

    private void Start()
    {
        DiePanel.SetActive(false);
    }

    void OnTriggerEnter()
    {
        JumpScare.Play();
        mCam.SetActive(false);
        jumpCam.SetActive(true);
        StartCoroutine(EndJump ());
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(2.03f);
        Cursor.visible = true;
        DiePanel.SetActive(true);
    }

}

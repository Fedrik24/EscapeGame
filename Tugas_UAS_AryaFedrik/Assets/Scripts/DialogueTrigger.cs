using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;


    public void OnTriggerEnter(Collider other)
    {
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}

}

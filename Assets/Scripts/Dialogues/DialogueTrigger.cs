﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
	public Dialogue noDatalog;
	public Animator animator;

	public void TriggerDialogue()
	{
		//if the player accesses the objective before accessing datalog, then different text will appear.
		if ((!animator.GetBool("Datalog"))&&animator.GetBool("Objective")){
			FindObjectOfType<DialogueManager>().StartDialogue(noDatalog);
		}else{
			FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
		}

	}

}
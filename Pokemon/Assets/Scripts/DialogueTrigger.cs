﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject dialogueUI;
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        dialogueUI.SetActive(true);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class NPCAnimationController : MonoBehaviour
{
    public Animator animator;
    public DialogueRunner dialogueRunner;

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("talking", dialogueRunner.IsDialogueRunning);
    }
}

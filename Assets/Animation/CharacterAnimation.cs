using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed;
    public float rotateSpeed;

    public AudioClip punchClip;
    public AudioSource audioSource;
    // Update is called once per frame
    void Update()
    {
        float xHorizontal = Input.GetAxis("Horizontal");
        float zVertical = Input.GetAxis("Vertical");
        if (xHorizontal != 0 || zVertical != 0)
        {
            animator.SetFloat("velocity", 1); // -1 => 1 l| 1=> 1
        }
        else
        {
            animator.SetFloat("velocity", 0);
        }
        animator.SetFloat("Pos X", xHorizontal);
        animator.SetFloat("Pos Y", zVertical);

        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("kick");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("punch");
        }
    }
    public void PlayPunchSound()
    {
        audioSource.PlayOneShot(punchClip);
    }
}

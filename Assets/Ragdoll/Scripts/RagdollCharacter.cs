using System;
using System.Collections.Generic;
using UnityEngine;

public class RagdollCharacter : MonoBehaviour
{
    public bool isActiveRagdoll = false;

    public Transform ragdollMain;
    public Transform animationMain;

    public List<Transform> ragdollBones;
    public List<Transform> animationBones;

    public List<Rigidbody> allRigids;
    public List<Collider> colliders;

    private bool currentIsRagdoll = true; // kiem tra hien tai co dang la ragdoll hay khong
    private void OnValidate()
    {
        allRigids = new List<Rigidbody>(ragdollMain.GetComponentsInChildren<Rigidbody>());
        colliders = new List<Collider>(ragdollMain.GetComponentsInChildren<Collider>());

        ragdollBones = new List<Transform>(ragdollMain.GetComponentsInChildren<Transform>());
        animationBones = new List<Transform>(animationMain.GetComponentsInChildren<Transform>());
    }
    private void Start()
    {
        DisableRagdoll();
    }

    public void Dead()
    {
        ActiveRagdoll();
    }
    private void Update()
    {
        if (isActiveRagdoll)
        {
            ActiveRagdoll();
        }
        else
        {
            DisableRagdoll();
            FollowRagdollBoneToAnimation();
        }
    }

    private void FollowRagdollBoneToAnimation()
    {
        for (int i = 0; i < ragdollBones.Count; i++)
        {
            ragdollBones[i].localPosition = animationBones[i].localPosition;
            ragdollBones[i].localRotation = animationBones[i].localRotation;
            ragdollBones[i].localScale = animationBones[i].localScale;
        }
    }

    private void DisableRagdoll()
    {
        if (!currentIsRagdoll) return;
        currentIsRagdoll = false;
        isActiveRagdoll = false;

        foreach (var rigidbody in allRigids)
        {
            rigidbody.isKinematic = true;
            rigidbody.useGravity = false;
        }
        foreach (var collider in colliders)
        {
            collider.enabled = false;
        }
    }

    private void ActiveRagdoll()
    {
        if (currentIsRagdoll) return;
        currentIsRagdoll = true;
        isActiveRagdoll = true;
        foreach (var rigidbody in allRigids)
        {
            rigidbody.isKinematic = false;
            rigidbody.useGravity = true;
        }
        foreach (var collider in colliders)
        {
            collider.enabled = true;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision other)
    {
        anim.SetTrigger("TargetHit");
    }
    public void ResetAnimation()
    {
        anim.SetTrigger("Reset");
    }
}

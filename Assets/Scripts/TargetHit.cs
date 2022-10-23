using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision other)
    {
        anim.SetTrigger("Hit");
    }

    public void ResetTarget()
    {
        anim.SetTrigger("Reset");
    }
}

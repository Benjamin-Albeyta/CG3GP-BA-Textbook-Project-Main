using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAnimator : MonoBehaviour
{
    NavMeshAgent navMesh;
    Animator animator;

    void Awake()
    {
        navMesh = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Velocity", navMesh.velocity.magnitude);
    }
}

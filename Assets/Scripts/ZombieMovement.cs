using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMovement : MonoBehaviour
{
    //this will not be a singleton
    //each zombie we make will have it's own movement script

    //we'll enable and disable this with our ZombieAI script.
    public bool IsMoving = false;
    //this will control the zombie movement speed.
    [SerializeField] private float MoveSpeed = 5f;

    //our rigidbody for movement
    //private CharacterController charController;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        //charController = GetComponent<CharacterController>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //if we're not moving, then exit the update
    //    if (!IsMoving)
    //    {
    //        //exit the Update
    //        return;
    //    }

    //    //move the zombie forward in the z axis only
    //    charController.SimpleMove(transform.TransformDirection(Vector3.forward) * MoveSpeed * Time.deltaTime);

    //}

    public void SetDestination(Vector3 dest)
    {
        navMeshAgent.SetDestination(dest);
    }
}

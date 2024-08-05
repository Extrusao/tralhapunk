using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movimento : MonoBehaviour
{
    Camera cam;
    NavMeshAgent agent;

    public LayerMask ground;

    private void Start(){
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update(){
        if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity, ground)){
                agent.SetDestination(hit.point);
            }
        }
    }
}
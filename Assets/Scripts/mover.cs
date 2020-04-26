using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class mover : MonoBehaviour
{

    [SerializeField] Transform target;
    Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }
        //Debug.DrawRay(lastRay.origin, lastRay.direction* 1000);
        // GetComponent<NavMeshAgent>().destination = target.position;
    }

    private void MoveToCursor()
    {
        RaycastHit hit;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
        
    }
}

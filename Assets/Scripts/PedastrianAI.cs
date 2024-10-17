using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PedestrianAI : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;

    public List<Transform> pathPoints;
    public float minDistance = 10;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        if (pathPoints == null)
        {
            Debug.LogError("Path points not assigned in PedestrianAI script.");
            return;
        }

        if (pathPoints.Count == 0)
        {
            Debug.LogError("No path points assigned in PedestrianAI script.");
            return;
        }
    }

    private void Update()
    {
        roam();
    }

    void roam()
    {
        if (Vector3.Distance(transform.position, pathPoints[index].position) < minDistance)
        {
            index = (index + 1) % pathPoints.Count;
        }

        agent.SetDestination(pathPoints[index].position);
    }


}

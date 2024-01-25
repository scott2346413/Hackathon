using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIDestinationController : MonoBehaviour
{
    public Transform destinationsParent;
    public float maxRandomRadius;
    public float waitAtDestination;

    public Animator animator;

    Transform[] destinations;
    NavMeshAgent agent;

    bool isWaiting = false;
    Vector3 previousPosition;

    // Start is called before the first frame update
    void Start()
    {
        destinations = destinationsParent.GetComponentsInChildren<Transform>();
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(destinations[Random.Range(0, destinations.Length - 1)].position);
        Debug.Log(destinations.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.velocity.magnitude == 0f && !isWaiting && Time.time > 0.5f)
        {
            StartCoroutine(Wait());
            isWaiting = true;
        }

        //previousPosition = transform.position;

        animator.SetBool("waiting", isWaiting);
        animator.SetFloat("randomness", Random.value);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitAtDestination);
        Vector3 destination = destinations[Random.Range(0, destinations.Length)].position + Random.insideUnitSphere * maxRandomRadius;
        agent.SetDestination(destination);

        yield return new WaitForSeconds(0.5f);
        isWaiting = false;
    }
}

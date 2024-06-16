using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentHelper
{
    public NavMeshAgent Agent => _agent;
    private NavMeshAgent _agent;

    public NavMeshAgentHelper(NavMeshAgent agent)
    {
        _agent = agent;
    }

    public void EnablesSmoothness() { }

    public void DisableSmoothness() { }

    private void SetSmoothness(bool isEnabled)
    {

    }

    public void SetDestination(Vector3 point)
    {

    }
}
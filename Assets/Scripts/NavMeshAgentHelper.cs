using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentHelper
{
    public float Speed => _agent.speed;

    private NavMeshAgent _agent;

    public NavMeshAgentHelper(NavMeshAgent agent)
    {
        _agent = agent;
    }

    public void EnablesSmoothness() => SetSmoothness(true);
    public void DisableSmoothness() => SetSmoothness(false);

    private void SetSmoothness(bool isEnabled)
    {

    }

    public void SetSpeed(float speed)
    {
        _agent.speed = speed;
    }

    public void SetDestination(Vector3 point)
    {
        _agent.SetDestination(point);
    }
}
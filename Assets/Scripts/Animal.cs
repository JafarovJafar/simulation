using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{
    public event UnityAction<Animal, Meal> EatenMeal;

    private NavMeshAgentHelper _navMeshAgentHelper;

    [SerializeField] private Meal _goalMeal;

    public void SetGoalMeal(Meal meal)
    {
        _goalMeal = meal;

        _navMeshAgentHelper.SetDestination(_goalMeal.Position);
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}
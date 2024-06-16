using UnityEngine;
using UnityEngine.Events;

public class Gameplay : MonoBehaviour
{
    public event UnityAction SimulationStarted;
    public event UnityAction SimulationFinished;

    private Animal[] _animals;
    private AnimalMealConnectors _connectors;

    public void Init
    (
        Animal[] animals,
        AnimalMealConnectors connectors
    )
    {
        _animals = animals;
        _connectors = connectors;

        foreach (var animal in _animals)
        {
            animal.EatenMeal += Animal_EatenMeal;
        }
    }

    private void Animal_EatenMeal(Animal animal, Meal meal)
    {

    }

    public void StartSimulation()
    {
        SimulationStarted?.Invoke();
    }
}
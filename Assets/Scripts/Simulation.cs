using UnityEngine;
using UnityEngine.Events;

public class Simulation
{
    public event UnityAction SimulationStarted;
    public event UnityAction SimulationFinished;

    private Field _field;
    private Animal[] _animals;
    private MealsFactory _mealsFactory;
    private MealPositionCalculator _mealPositionCalculator;

    public void StartSimulation
    (
        Field field,
        Animal[] animals,
        MealsFactory mealsFactory,
        MealPositionCalculator mealPositionCalculator
    )
    {
        _field = field;
        _animals = animals;
        _mealsFactory = mealsFactory;
        _mealPositionCalculator = mealPositionCalculator;

        for (int i = 0; i < _animals.Length; i++)
        {
            var animal = _animals[i];
            animal.SetId(i);
            animal.EatenMeal += Animal_EatenMeal;
        }

        for (int i = 0; i < _animals.Length; i++)
        {
            var newMeal = _mealsFactory.SpawnAt(i, Vector3.right * 2f);

            _animals[i].SetGoalMeal(newMeal);
        }

        SimulationStarted?.Invoke();
    }

    private void Animal_EatenMeal(Animal animal)
    {
        //var position = new Vector3();
        //if (animal.transform.position.x > 0) position.x = -2f;
        //else position.x = 2f;

        var position = _mealPositionCalculator.GetMealPosition(_field, null, animal);

        var newMeal = _mealsFactory.SpawnAt(animal.Id, position);
        animal.SetGoalMeal(newMeal);
    }

    public void StopSimulation()
    {

    }
}
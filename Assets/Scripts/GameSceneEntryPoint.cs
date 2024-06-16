using UnityEngine;
using EasyButtons;

public class GameSceneEntryPoint : MonoBehaviour
{
    [SerializeField] private int _fieldSize;
    [SerializeField] private int _animalsCount;

    [SerializeField] private GameCamera _camera;

    [SerializeField] private Field _field;

    [SerializeField] private AnimalsFactory _animalsFactory;
    [SerializeField] private MealsFactory _mealsFactory;

    [SerializeField] private EntityColorDrawer _entityColorDrawer;
    [SerializeField] private MealPositionCalculator _mealPositionCalculator;

    private Simulation _simulation;
    private AnimalsCountLimiter _animalsCountLimiter;

    private void Start()
    {
        _camera.Init();
        _field.Init();

        _animalsFactory.Init(_entityColorDrawer);
        _mealsFactory.Init(_entityColorDrawer);

        _animalsCountLimiter = new AnimalsCountLimiter();

        _simulation = new Simulation();
    }

    [Button]
    private void StartSimulation
    (
        int levelSize,
        int animalsCount,
        float animalsSpeed
    )
    {
        _camera.SetSize(levelSize);
        _field.SetSize(levelSize);

        animalsCount = _animalsCountLimiter.GetAnimalsCount(levelSize, animalsCount);

        for (int i = 0; i < animalsCount; i++)
        {
            //var newAnimal = _animalsFactory.SpawnAt()
        }

        var newAnimal = _animalsFactory.SpawnAt(0, Vector3.zero);
        var animals = new Animal[] { newAnimal };

        _simulation.StartSimulation(_field, animals, _mealsFactory, _mealPositionCalculator);
    }
}
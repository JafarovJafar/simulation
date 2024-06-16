using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;
using Shafir.MonoPool;

public class Animal : MonoBehaviour, IPoolable, IColorable
{
    public event UnityAction<Animal> EatenMeal;

    public bool IsActive => _gameObject.activeSelf;
    public int Id => _id;
    public float Speed => _navMeshAgentHelper.Speed;
    public Vector3 Position => _transform.position;

    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private NavMeshAgent _agent;

    private Meal _goalMeal;

    private int _id;
    private NavMeshAgentHelper _navMeshAgentHelper;
    private Transform _transform;
    private GameObject _gameObject;

    private void Awake()
    {
        _transform = transform;
        _gameObject = gameObject;

        _navMeshAgentHelper = new NavMeshAgentHelper(_agent);
        _navMeshAgentHelper.DisableSmoothness();
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public void SetSpeed(float speed)
    {
        _navMeshAgentHelper.SetSpeed(speed);
    }

    public void SetGoalMeal(Meal meal)
    {
        _goalMeal = meal;

        _navMeshAgentHelper.SetDestination(_goalMeal.Position);
    }

    public void Activate()
    {
        _gameObject.SetActive(true);
    }

    public void DeActivate()
    {
        _gameObject.SetActive(false);
    }

    public void SetPosition(Vector3 position)
    {
        _transform.position = position;
    }

    public void SetColor(Color color)
    {
        var material = _renderer.material;
        material.color = color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<Meal>(out var meal)) return;
        if (meal != _goalMeal) return;

        meal.SetEaten();

        EatenMeal?.Invoke(this);
    }
}
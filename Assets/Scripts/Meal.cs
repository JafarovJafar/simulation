using UnityEngine;
using Shafir.MonoPool;

public class Meal : MonoBehaviour, IPoolable, IColorable
{
    public bool IsActive => _gameObject.activeSelf;
    public Vector3 Position => _transform.position;
    public int Id => _id;

    [SerializeField] private MeshRenderer _renderer;

    private int _id;

    private Transform _transform;
    private GameObject _gameObject;

    private void Awake()
    {
        _transform = transform;
        _gameObject = gameObject;
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public void SetColor(Color color)
    {
        var material = _renderer.material;
        material.color = color;
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

    public void SetEaten()
    {
        // тут можно реализовать машину состояний и сделать состояние с анимацией и партиклами
        DeActivate();
    }
}
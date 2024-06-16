using UnityEngine;
using UnityEngine.AI;

public class Field : MonoBehaviour
{
    public float Size => _size;

    [SerializeField] private NavMeshSurface _surface;

    private float _size;
    private Transform _transform;

    public void Init()
    {
        _transform = transform;
    }

    public void SetSize(int size)
    {
        _size = size;
        _transform.localScale = new Vector3(size, 1f, size);
        _surface.BuildNavMesh();
    }
}
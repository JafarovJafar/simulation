using UnityEngine;

public class Meal : MonoBehaviour
{
    public Vector3 Position => _transform.position;

    [SerializeField] private MeshRenderer _renderer;

    private Transform _transform;

    public void Init()
    {
        _transform = transform;
    }

    public void SetColor(Color color)
    {
        var material = _renderer.sharedMaterial;
        material.color = color;
    }
}
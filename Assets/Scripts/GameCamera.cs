using UnityEngine;

public class GameCamera : MonoBehaviour
{
    [SerializeField] private float _sizeMultiplier = 10f;

    private Transform _transform;

    public void Init()
    {
        _transform = transform;
    }

    public void SetSize(int size)
    {
        float finalSize = size * _sizeMultiplier;
        _transform.position = new Vector3(0, finalSize, -finalSize);
    }
}
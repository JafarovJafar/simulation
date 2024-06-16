using UnityEngine;

public class Field : MonoBehaviour
{
    private Transform _transform;

    public void SetSize(int size)
    {
        _transform.localScale = new Vector3(size, 1f, size);
    }
}
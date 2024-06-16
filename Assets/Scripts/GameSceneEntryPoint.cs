using UnityEngine;

public class GameSceneEntryPoint : MonoBehaviour
{
    [SerializeField] private int _fieldSize;
    [SerializeField] private int _animalsCount;

    [SerializeField] private Field _field;

    private void Start()
    {
        _field.SetSize(_field);
    }
}
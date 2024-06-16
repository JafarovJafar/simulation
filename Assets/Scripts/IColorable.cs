using UnityEngine;

public interface IColorable
{
    int Id { get; }

    void SetColor(Color color);
}
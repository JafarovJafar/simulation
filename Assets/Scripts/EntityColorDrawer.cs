using System.Collections.Generic;
using UnityEngine;

public class EntityColorDrawer : MonoBehaviour
{
    [SerializeField] private List<Color> _colors;

    public void DrawColor(IColorable colorable)
    {
        int id = colorable.Id;
        int colorIdx = id % _colors.Count;
        var color = _colors[colorIdx];
        colorable.SetColor(color);
    }
}
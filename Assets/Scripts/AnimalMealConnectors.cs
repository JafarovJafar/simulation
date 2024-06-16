using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AnimalMealConnectors")]
public class AnimalMealConnectors : ScriptableObject
{
    public IReadOnlyList<AnimalMealConnector> Connectors => _connectors;
    [SerializeField] private List<AnimalMealConnector> _connectors;
}
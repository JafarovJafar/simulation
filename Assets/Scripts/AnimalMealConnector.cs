using System;
using UnityEngine;

[Serializable]
public class AnimalMealConnector
{
    public Animal Animal => _animal;
    public Meal Meal => _meal;

    [SerializeField] private Animal _animal;
    [SerializeField] private Meal _meal;
}
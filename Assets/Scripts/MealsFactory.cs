using UnityEngine;
using Shafir.MonoPool;

public class MealsFactory : MonoBehaviour
{
    [SerializeField] private Meal _mealPrefab;

    private EntityColorDrawer _colorDrawer;
    private Transform _transform;

    public void Init(EntityColorDrawer colorDrawer)
    {
        _colorDrawer = colorDrawer;
        _transform = transform;
    }

    public Meal SpawnAt(int id, Vector3 position)
    {
        var newMeal = MonoPool.Get(_mealPrefab, _transform);
        _colorDrawer.DrawColor(newMeal);
        newMeal.SetId(id);
        newMeal.SetPosition(position);
        return newMeal;
    }
}
using UnityEngine;
using Shafir.MonoPool;

public class AnimalsFactory : MonoBehaviour
{
    [SerializeField] private Animal _animalPrefab;

    private EntityColorDrawer _colorDrawer;
    private Transform _transform;

    public void Init(EntityColorDrawer colorDrawer)
    {
        _colorDrawer = colorDrawer;
        _transform = transform;
    }

    public Animal SpawnAt(int id, Vector3 position)
    {
        var newAnimal = MonoPool.Get(_animalPrefab, _transform);
        _colorDrawer.DrawColor(newAnimal);
        newAnimal.SetId(id);
        newAnimal.SetPosition(position);
        return newAnimal;
    }
}
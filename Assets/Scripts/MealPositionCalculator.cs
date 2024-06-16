using System.Collections.Generic;
using UnityEngine;

public class MealPositionCalculator : MonoBehaviour
{
    [SerializeField] private float _padding; // отступ от краев игрового поля
    [SerializeField] private int _estimationSeconds;

    public Vector3 GetMealPosition
    (
        Field field, // поле, на котором надо найти позицию для еды
        List<Meal> existingMeals, // список существующей на данный момент пищи на поле
        Animal animal // животное, для которого делается расчет
    )
    {
        float fieldSize = field.Size;
        fieldSize -= _padding * 2f;



        float estimatedAnimalDistance = animal.Speed * _estimationSeconds;





        Vector3 finalPos = animal.Position;
        if (finalPos.x > 0) finalPos.x = -2f;
        else finalPos.x = 2f;

        finalPos.z = Random.Range(-fieldSize / 2f, fieldSize / 2f);

        return finalPos;


        Debug.LogWarning($"Не удалось найти корректную позицию для еды с Id={animal.Id}. Установил позицию в середине поля");
        return Vector3.zero;
    }
}
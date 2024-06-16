using System.Collections.Generic;
using UnityEngine;

public class MealPositionCalculator : MonoBehaviour
{
    [SerializeField] private float _padding; // ������ �� ����� �������� ����
    [SerializeField] private int _estimationSeconds;

    public Vector3 GetMealPosition
    (
        Field field, // ����, �� ������� ���� ����� ������� ��� ���
        List<Meal> existingMeals, // ������ ������������ �� ������ ������ ���� �� ����
        Animal animal // ��������, ��� �������� �������� ������
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


        Debug.LogWarning($"�� ������� ����� ���������� ������� ��� ��� � Id={animal.Id}. ��������� ������� � �������� ����");
        return Vector3.zero;
    }
}
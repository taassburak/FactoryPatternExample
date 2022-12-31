using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CarType
{
    SportCar,
    MuscleCar
}

public class CarFactory : MonoBehaviour
{
    [SerializeField] private BaseCarBehaviour _sportCarPrefab;
    [SerializeField] private BaseCarBehaviour _muscleCarPrefab;

    public BaseCarBehaviour GetCar(CarType carType)
    {
        switch (carType)
        {
            case CarType.SportCar: 
                return _sportCarPrefab;
                break;
            case CarType.MuscleCar:
                return _muscleCarPrefab;
                break;
            default:
                break;
        }

        return null;
    }
}

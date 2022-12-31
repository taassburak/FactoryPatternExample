using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] CarFactory _carFactory;

    void Start()
    {
        StartCoroutine(CreateCarCo());
    }


    private IEnumerator CreateCarCo()
    {
        while (true)
        {

            BaseCarBehaviour baseCarBehaviour = null;

            if (Random.Range(0, 2) == 0)
            {
                baseCarBehaviour = _carFactory.GetCar(CarType.SportCar);
            }
            else
            {
                baseCarBehaviour = _carFactory.GetCar(CarType.MuscleCar);
            }

            var instantiatedCar = Instantiate(baseCarBehaviour, _carFactory.transform.position, Quaternion.identity);
            instantiatedCar.Move();


            yield return new WaitForSeconds(1.5f);
        }
    }


}

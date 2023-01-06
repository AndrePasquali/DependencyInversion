using System;
using UnityEngine;

namespace HeartAttackGames.DependencyInversion
{
    public class Car: MonoBehaviour
    {
        [SerializeField] private CarSettings _carSettings;

        private ICarInput _carInput;
        private CarMotor _carMotor;

        private void Awake()
        {
            _carInput = new CarControllerInput();
            _carMotor = new CarMotor(_carInput, transform, _carSettings);
        }

        private void Update()
        {
            _carInput.ReadInput();
            _carMotor.EveryFrame();
        }
    }
}
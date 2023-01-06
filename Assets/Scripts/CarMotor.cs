using UnityEngine;

namespace HeartAttackGames.DependencyInversion
{
    public class CarMotor
    {
        private readonly ICarInput _carInput;
        private readonly Transform _transformToMove;
        private readonly CarSettings _carSettings;

        public CarMotor(ICarInput carInput, Transform transformToMove, CarSettings carSettings)
        {
            _carInput = carInput;
            _transformToMove = transformToMove;
            _carSettings = carSettings;
        }

        public void EveryFrame()
        {
            _transformToMove.Rotate(Vector3.left * (_carInput.TurnSpeed * Time.deltaTime * _carInput.TurnSpeed));
            _transformToMove.position += _transformToMove.forward * (_carInput.Speed * Time.deltaTime * _carSettings.MaxSpeed);
        }
    }
}
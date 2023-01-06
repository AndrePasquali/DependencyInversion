using UnityEngine;

namespace HeartAttackGames.DependencyInversion
{
    public class CarControllerInput: ICarInput
    {
        public void ReadInput()
        {
            TurnSpeed = Input.GetAxis("Horizontal");
            Speed = Input.GetAxis("Vertical");
        }

        public float TurnSpeed { get; private set; }
        public float Speed { get; private set; }
    }
}
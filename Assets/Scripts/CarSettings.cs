using UnityEngine;

[CreateAssetMenu(menuName = "Car/Settings", fileName = "CarData")]
public class CarSettings : ScriptableObject
{
   public float MaxSpeed => _maxSpeed;
   [SerializeField] private float _maxSpeed;

   public float Acceleration => _acceleration;
   [SerializeField] private float _acceleration;

   public float Breaking => _breaking;
   [SerializeField] private float _breaking;
}

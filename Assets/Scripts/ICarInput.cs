namespace HeartAttackGames.DependencyInversion
{
    public interface ICarInput
    {
        public void ReadInput();
        public float TurnSpeed { get; }
        public float Speed { get; }
    }
}
namespace Fuel.Models
{
    public class FuelStation
    {
        private int _volumeInput { get; set; }
        private int _volumeStorage { get; set; }
        public FuelStation(int volumeStorage, int volumeInput)
        {
            _volumeStorage = volumeStorage;
            _volumeInput = volumeInput;
        }
        public int CalculateStorage()
            => _volumeStorage - _volumeInput;
    }
}

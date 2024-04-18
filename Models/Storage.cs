namespace Fuel.Models
{
    public class Storage
    {
        private int _volumeStorage { get; set; }
        public Storage(int volumeStorage)
        {
            _volumeStorage = volumeStorage;
        }
        public int CalculateStorage()
            => _volumeStorage;
    }
}

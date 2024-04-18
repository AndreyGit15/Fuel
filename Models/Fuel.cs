namespace Fuel.Models
{
    public class Fuel
    {

        private int _volume { get; set; }
        private int _density { get; set; }
        public Fuel(int volume, int density)
        {
            _density = density;
            _volume = volume;
        }
        public int CalculateWeight()
            => _density * _volume;
    }
}

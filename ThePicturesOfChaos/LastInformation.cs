namespace ThePicturesOfChaos
{
    internal class LastInformation
    {
        private float _x;
        private float _y;
        private float _angle;

        public LastInformation(float x, float y, float angle)
        {
            _x = x;
            _y = y;
            _angle = angle;
        }

        public float X => _x;

        public float Y => _y;

        public float Angle => _angle;
    }
}

using System.Drawing;

namespace PhotoEnhancer
{
    public class LeftShiftTransformer : ITransformer<LeftShiftParameters>
    {
        public Size ResultSize { get; private set; }
        private LeftShiftParameters _parameters;
        private int shiftPixels;

        public void Initialize(Size size, LeftShiftParameters parameters)
        {
            this.ResultSize = size;
            this._parameters = parameters;
            this.shiftPixels =  (int)(this._parameters.Shift * ResultSize.Width / 100);
        }

        public Point? MapPoint(Point newPoint)
        {
            return new Point((newPoint.X + shiftPixels) %ResultSize.Width, newPoint.Y);
        }
    }
}

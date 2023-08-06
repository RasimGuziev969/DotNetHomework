namespace PhotoEnhancer
{
    public class LeftShiftParameters : IParameters
    {
        [ParameterInfo(Name = "Сдвиг %",
                    MinValue = 0,
                    MaxValue = 100,
                    DefaultValue = 0,
                    Increment = 5)]
        public double Shift { get; set; }
    }
    
}

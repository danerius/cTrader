using cAlgo.API;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;

namespace cAlgo.Indicators
{
    [Indicator(IsOverlay = true, TimeZone = TimeZones.UTC, AccessRights = AccessRights.None)]
    public class FibonacciEMAs : Indicator
    {
        [Parameter("EMA Period 1", DefaultValue = 21)]
        public int EMA_Period_1 { get; set; }

        [Parameter("EMA Period 2", DefaultValue = 34)]
        public int EMA_Period_2 { get; set; }

        [Parameter("EMA Period 3", DefaultValue = 55)]
        public int EMA_Period_3 { get; set; }

        [Parameter("EMA Period 4", DefaultValue = 89)]
        public int EMA_Period_4 { get; set; }

        [Parameter("EMA Period 5", DefaultValue = 144)]
        public int EMA_Period_5 { get; set; }

        [Parameter("EMA Period 6", DefaultValue = 233)]
        public int EMA_Period_6 { get; set; }

        [Parameter("EMA Period 7", DefaultValue = 377)]
        public int EMA_Period_7 { get; set; }

        [Parameter("EMA Period 8", DefaultValue = 610)]
        public int EMA_Period_8 { get; set; }

        [Output("EMA 1", LineColor = "White")]
        public IndicatorDataSeries EMA_1 { get; set; }

        [Output("EMA 2", LineColor = "White")]
        public IndicatorDataSeries EMA_2 { get; set; }

        [Output("EMA 3", LineColor = "White")]
        public IndicatorDataSeries EMA_3 { get; set; }

        [Output("EMA 4", LineColor = "White")]
        public IndicatorDataSeries EMA_4 { get; set; }

        [Output("EMA 5", LineColor = "White")]
        public IndicatorDataSeries EMA_5 { get; set; }

        [Output("EMA 6", LineColor = "White")]
        public IndicatorDataSeries EMA_6 { get; set; }

        [Output("EMA 7", LineColor = "White")]
        public IndicatorDataSeries EMA_7 { get; set; }

        [Output("EMA 8", LineColor = "White")]
        public IndicatorDataSeries EMA_8 { get; set; }

        private int[] EMA_Periods;

        protected override void Initialize()
        {
            EMA_Periods = new int[8] {
                EMA_Period_1, EMA_Period_2, EMA_Period_3, EMA_Period_4,
                EMA_Period_5, EMA_Period_6, EMA_Period_7, EMA_Period_8
            };
        }

        public override void Calculate(int index)
        {
            // Calculation logic will be added here
        }
    }
}

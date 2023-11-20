namespace CarImport.Infrastructure.Helpers
{
    public class Currency
    {

        public Data data { get; set; }

        public class Data
        {
            public float EUR { get; set; }
            public float ILS { get; set; }
            public float USD { get; set; }
            
        }
    }
}

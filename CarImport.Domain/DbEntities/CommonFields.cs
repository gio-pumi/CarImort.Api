namespace CarImport.Domain.DbEntities
{
    public class CommonFields
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public string RegisterByUser { get; set; } 

        public DateTime LastModifyDate { get; set; }

        public string LastModifierUser { get; set; } 
    }
}


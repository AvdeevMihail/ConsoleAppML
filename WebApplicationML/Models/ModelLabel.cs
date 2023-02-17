namespace WebApplicationML.Models
{
    public class ModelLabel
    {
        public int Id { get; set; }

        public string Label { get; set; }

        public string Name { get; set; }

        public float Score { get; set; }

        public static List<ModelLabel> GetLabels()
        {
            return new List<ModelLabel>()
                {
                    new ModelLabel { Id = 0, Label = "crescent_gap", Name = "crescent_gap" },
                    new ModelLabel { Id = 1, Label = "crease", Name = "crease" },
                    new ModelLabel { Id = 2, Label = "inclusion", Name = "inclusion" },
                    new ModelLabel { Id = 3, Label = "oil_spot", Name = "oil_spot" },
                    new ModelLabel { Id = 4, Label = "punching_hole", Name = "punching_hole" },
                    new ModelLabel { Id = 5, Label = "rolled_pit", Name = "rolled_pit" },
                    new ModelLabel { Id = 6, Label = "silk_spot", Name = "silk_spot" },
                    new ModelLabel { Id = 7, Label = "waist folding", Name = "waist folding" },
                    new ModelLabel { Id = 8, Label = "water_spot", Name = "water_spot" },
                    new ModelLabel { Id = 9, Label = "welding_line", Name = "welding_line" },
                };
        }
    }
}

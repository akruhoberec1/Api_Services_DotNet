namespace WebApi_BestPractices.Services.VehicleServices
{
    public class VehicleService : IVehicleService
    {
        private static List<VehicleMake> makes = new List<VehicleMake>
        {
            new VehicleMake
            {
                Id = 1,
                Name = "Volkswagen",
                Abrv = "VW"
            },
            new VehicleMake
            {
                Id = 2,
                Name = "Bayerische Motoren Werke",
                Abrv = "BMW"
            },
        };
        public List<VehicleMake> AddMake(VehicleMake make)
        {
            makes.Add(make);
            return makes;
        }

        public List<VehicleMake> GetAllMakes()
        {
            return makes;
        }

        public VehicleMake? GetSingleMake(int id)
        {
            var make = makes.Find(x => x.Id == id);
            if (make is null)
                return null;
            return make;
        }

        public List<VehicleMake>? UpdateSingleMake(int id, VehicleMake request)
        {
            var make = makes.Find(x => x.Id == id);
            if (make is null)
                return null; 

            make.Name = request.Name;
            make.Abrv = request.Abrv;

            return makes;
        }

        public List<VehicleMake>? DeleteMake(int id)
        {
            var make = makes.Find(x => x.Id == id);
            if (make is null)
                return null; 

            makes.Remove(make);

            return makes;
        }
    }
}

using WebApi_BestPractices.Data;

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

        private static List<VehicleModel> models = new List<VehicleModel>
        {
            new VehicleModel
            {
                Id = 1,
                MakeId = 1,
                Name = "Golf 8 Skyrunner",
                Abrv = "golf es"
            },
            new VehicleModel 
            {
                Id = 2,
                MakeId = 2,
                Name = "D360i Runner",
                Abrv = "X5"
            }

        };

        private readonly DataContext _context;

        public VehicleService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<VehicleMake>> AddMake(VehicleMake make)
        {
            _context.VehicleMakes.Add(make);
            await _context.SaveChangesAsync();  

            return makes;
        }

        public async Task<List<VehicleMake>> GetAllMakes()
        {
            var makes = await _context.VehicleMakes.ToListAsync();  
            return makes;
        }

        public async Task<VehicleMake?> GetSingleMake(int id)
        {
            var make = await _context.VehicleMakes.FindAsync(id);
            if (make is null)
                return null;
            return make;
        }

        public async Task<List<VehicleMake>?> UpdateSingleMake(int id, VehicleMake request)
        {
            var make = await _context.VehicleMakes.FindAsync(id);
            if (make is null)
                return null; 

            make.Name = request.Name;
            make.Abrv = request.Abrv;

            await _context.SaveChangesAsync();  

            return makes;
        }

        public async Task<List<VehicleMake>?> DeleteMake(int id)
        {
            var make = await _context.VehicleMakes.FindAsync(id);
            if (make is null)
                return null; 

            _context.VehicleMakes.Remove(make);
            await _context.SaveChangesAsync();  

            return makes;
        }

        public async Task<List<VehicleModel>> AddModel(VehicleModel model)
        {
            _context.VehicleModels.Add(model);
            await _context.SaveChangesAsync();

            return models;
        }

        public async Task<List<VehicleModel>> GetAllModels()
        {
            var models = await _context.VehicleModels.ToListAsync();
            return models;
        }

        public async Task<VehicleModel?> GetSingleModel(int id)
        {
            var model = await _context.VehicleModels.FindAsync(id);
            if (model is null)
                return null;
            return model;
        }

        public async Task<List<VehicleModel>?> UpdateSingleModel(int id, VehicleModel request)
        {
            var model = await _context.VehicleModels.FindAsync(id);
            if (model is null)
                return null;

            model.MakeId = request.MakeId;
            model.Name = request.Name;
            model.Abrv = request.Abrv;

            await _context.SaveChangesAsync();

            return models;
        }

        public async Task<List<VehicleModel>?> DeleteModel(int id)
        {
            var model = await _context.VehicleModels.FindAsync(id);
            if (model is null)
                return null;

            _context.VehicleModels.Remove(model);
            await _context.SaveChangesAsync();

            return models;
        }
    }
}

namespace WebApi_BestPractices.Services.VehicleServices
{
    public interface IVehicleService
    {
        Task<List<VehicleMake>> GetAllMakes();

        Task<VehicleMake?> GetSingleMake(int id);

        Task<List<VehicleMake>> AddMake(VehicleMake make);

        Task<List<VehicleMake>?> UpdateSingleMake(int id, VehicleMake request);

        Task<List<VehicleMake>?> DeleteMake(int id);

        Task<List<VehicleModel>> GetAllModels();

        Task<VehicleModel?> GetSingleModel(int id);

        Task<List<VehicleModel>> AddModel(VehicleModel model);

        Task<List<VehicleModel>?> UpdateSingleModel(int id, VehicleModel request);

        Task<List<VehicleModel>?> DeleteModel(int id);

    }
}

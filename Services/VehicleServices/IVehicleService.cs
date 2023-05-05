namespace WebApi_BestPractices.Services.VehicleServices
{
    public interface IVehicleService
    {
        Task<List<VehicleMake>> GetAllMakes();

        Task<VehicleMake?> GetSingleMake(int id);

        Task<List<VehicleMake>> AddMake(VehicleMake make);

        Task<List<VehicleMake>?> UpdateSingleMake(int id, VehicleMake request);

        Task<List<VehicleMake>?> DeleteMake(int id);

    }
}

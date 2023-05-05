namespace WebApi_BestPractices.Services.VehicleServices
{
    public interface IVehicleService
    {
        List<VehicleMake> GetAllMakes();

        VehicleMake? GetSingleMake(int id);

        List<VehicleMake> AddMake(VehicleMake make);

        List<VehicleMake>? UpdateSingleMake(int id, VehicleMake request);

        List<VehicleMake>? DeleteMake(int id);

    }
}

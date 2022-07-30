using System;

public class FreightCar : Car
{
    private float _maxCapacity;
    private float _carryingCapacity;

    public float MaxCapacity { get { return _maxCapacity; } }
    public float CarryingCapacity { get { return _carryingCapacity; } }

    private const float _decreaseDriveReserve = 0.04f;

    public FreightCar(int speed, float averageFuelConsumption, float volumeFuelTank, float volumeFuel, float carryingCapacity, float maxCapacity)
        : base(CarTypes.FreightCar, speed, averageFuelConsumption, volumeFuelTank, volumeFuel)
    {
        _maxCapacity = maxCapacity;
        _carryingCapacity = carryingCapacity;

        if (carryingCapacity > maxCapacity)
        {
            throw new Exception($"Максимальное количество груза: {maxCapacity}");
        }
    }

    public override float DriveDistanceFromWeight(float volumeFuel)
    {
        return DriveDistance(volumeFuel) * (1 - ((_decreaseDriveReserve / 200) * _carryingCapacity));
    }
}
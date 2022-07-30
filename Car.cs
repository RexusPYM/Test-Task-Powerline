using System;

public enum CarTypes
{
    PassengerCar,
    FreightCar,
    SportCar
}

public abstract class Car
{
    private CarTypes _carType;
    private float _speed;
    private float _averageFuelConsumption;
    private float _volumeFuelTank;
    private float _volumeFuel;

    public CarTypes CarType { get { return _carType; } }
    public float Speed { get { return _speed;  } }
    public float AverageFuelConsumption { get { return _averageFuelConsumption; } }
    public float VolumeFuelTank { get { return _volumeFuelTank; } }
    public float VolumeFuel { get { return _volumeFuel; } }

    public Car(CarTypes carType, int speed, float averageFuelConsumption, float volumeFuelTank, float volumeFuel)
    {
        _carType = carType;
        _speed = speed;
        _averageFuelConsumption = averageFuelConsumption;
        _volumeFuelTank = volumeFuelTank;
        _volumeFuel = volumeFuel;
    }

    protected float DriveDistance(float volumeFuel)
    {
        return volumeFuel / _averageFuelConsumption;
    }

    public float DriveTime(float volumeFuel)
    {
        return DriveDistance(volumeFuel) / _speed;
    }

    public float ShowDriveDistance(float volumeFuel)
    {
        return DriveDistance(volumeFuel);
    }

    public virtual float DriveDistanceFromWeight(float volumeFuel)
    {
        return DriveDistance(volumeFuel);
    }

}

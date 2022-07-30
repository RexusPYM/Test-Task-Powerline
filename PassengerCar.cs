using System;

public class PassengerCar : Car
{
    private int _amountPassengers;
    private int _maxPassengers;

    public int AmountPassengers { get { return _amountPassengers; } }
    public int MaxPassengers { get{ return _maxPassengers; } }

    private const float _decreaseDriveReserve = 0.06f;

    public PassengerCar(int speed, int amountPassengers, int maxPassengers, float averageFuelConsumption, float volumeFuelTank, float volumeFuel)
        : base(CarTypes.PassengerCar, speed, averageFuelConsumption, volumeFuelTank, volumeFuel)
    {
        _maxPassengers = maxPassengers;
        _amountPassengers = amountPassengers;

        if (_amountPassengers > _maxPassengers)
        {
            throw new Exception($"Максимальное количество пассажиров: {_maxPassengers}");
        }
    }

    public override float DriveDistanceFromWeight(float volumeFuel)
    {
        return DriveDistance(volumeFuel) * (1 - (_decreaseDriveReserve * _amountPassengers));
    }
}

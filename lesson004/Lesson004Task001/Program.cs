Building b1 = new Building(1, 1, 1, 1);
Building b2 = new Building(2, 2, 2, 2);
Building b3 = new Building(3, 3, 3, 3);
Building b4 = new Building();

Console.WriteLine(b1.GetId());
Console.WriteLine(b2.GetId());
Console.WriteLine(b3.GetId());
Console.WriteLine(b4.GetId());


public class Building
{
    private readonly int _id; //уникальный номер здания
    private readonly int _height; //высота
    private readonly int _storeys; // этажность
    private readonly int _apartments; // количество квартир
    private readonly int _entrances; // количество подьездов

    private static int _lastId = default(int);

    public Building() : this(10, 3, 1, 1)
    {
    }

    public Building(int height, int storeys, int apartments, int entrances)
    {
        _id = GenerateId();
        _height = height;
        _storeys = storeys;
        _apartments = apartments;
        _entrances = entrances;
    }

    private int GenerateId()
    {
        _lastId++;
        return _lastId;
    }

    public int GetId()
    {
        return _id;
    }

    public int GetHeight()
    {
        return _height;
    }

    public int GetStoreys()
    {
        return _storeys;
    }

    public int GetApartments()
    {
        return _apartments;
    }

    public int GetEntrances()
    {
        return _entrances;
    }
}
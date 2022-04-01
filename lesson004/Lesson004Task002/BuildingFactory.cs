namespace Lesson004Task002;

public class BuildingFactory
{
    private static readonly Dictionary<int, Building> _dict;
    
    static BuildingFactory()
    {
        _dict = new Dictionary<int, Building>();
    }
    
    public static Building CreateBuilding()
    {
        return new Building();
    }
    
    public static Building CreateBuilding(int height, int storeys, int apartments, int entrances)
    {
        var building =  new Building(height, storeys, apartments, entrances);
        AddBuildingToDictionary(building);
        return building;
    }

    private static void AddBuildingToDictionary(Building building)
    {
        _dict.Add(building.GetId(), building);
    }
}
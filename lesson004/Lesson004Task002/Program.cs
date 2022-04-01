namespace Lesson004Task002
{
    internal class Program
    {
        static void Main()
        {
            Building b = BuildingFactory.CreateBuilding();
            Building c = BuildingFactory.CreateBuilding();
            Building d = BuildingFactory.CreateBuilding();
            Console.WriteLine(b.GetId());
            Console.WriteLine(c.GetId());
            Console.WriteLine(d.GetId());
        }
    }

    public class Building
    {
        private readonly int _id; //уникальный номер здания
        private readonly int _height; //высота
        private readonly int _storeys; // этажность
        private readonly int _apartments; // количество квартир
        private readonly int _entrances; // количество подьездов

        private static int _lastId = default(int);

        //Делаем конструктор internal
        internal Building() : this(10, 3, 1, 1)
        {
        }

        //Делаем конструктор internal
        internal Building(int height, int storeys, int apartments, int entrances)
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
}
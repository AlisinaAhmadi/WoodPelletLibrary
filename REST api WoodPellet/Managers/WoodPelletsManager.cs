using DoodPelletibrary;

namespace REST_api_WoodPellet.Managers
{
    public class WoodPelletsManager
    {
        private static int _nextId = 1;
        private static readonly List<Wodpeller> Data = new List<Wodpeller>
        {
            new Wodpeller {Id = _nextId++, Brand = "A", Price = 12, Quality = 1},
            new Wodpeller {Id=_nextId++, Brand = "B", Price = 11, Quality =2},
             new Wodpeller {Id=_nextId++, Brand = "C", Price = 10, Quality =3},
             new Wodpeller {Id=_nextId++, Brand = "D", Price = 9, Quality = 4},     
             new Wodpeller {Id=_nextId++, Brand = "E", Price = 8, Quality = 5},
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };
        public List<Wodpeller> GetAll()
        {
            return new List<Wodpeller>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }
        public Wodpeller GetById(int id)
        {
            return Data.Find(Wodpeller => Wodpeller.Id == id);
        }
        public Wodpeller Add(Wodpeller newwodpeller)
        {
            newwodpeller.Id = _nextId++;
            Data.Add(newwodpeller);
            return newwodpeller;
        }
        public Wodpeller  Update(int id, Wodpeller updates)
        {
            Wodpeller wodpeller = Data.Find(Wodpeller1 => Wodpeller1.Id == id);
            if (wodpeller == null) return null;
            wodpeller.Id = updates.Id;
            wodpeller.Price = updates.Price;
            wodpeller.Quality = updates.Quality;
            return wodpeller;
        }
    }
}

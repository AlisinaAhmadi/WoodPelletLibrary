using System.Xml.Linq;

namespace DoodPelletibrary
{
    public class Wodpeller
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public int Quality { get; set; }

        public void ValidateBrand()
        {
            if (Brand.Length < 2) throw new ArgumentException("name must be at least 2 character: " + Brand);
        }
        public void ValidatePrice()
        {
            if (Price < 0)
                throw new ArgumentOutOfRangeException("price must be non-negative: " + Price);
        }

        public void ValidateQuality()
        {
            if (Quality< 1 || Quality > 5) throw new ArgumentNullException("ShirtNumber must be minimum 1 and maximum 5: " + Quality);

        }
        public void Validate()
        {
            ValidateBrand();
            ValidatePrice();
            ValidateQuality();
        }
        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Brand)}={Brand}, {nameof(Price)}={Price},{nameof(Quality)} = {Quality.ToString()}}}";


        }
    }
}
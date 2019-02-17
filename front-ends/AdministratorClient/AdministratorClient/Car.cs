using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorClient
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Car
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "driver_id", Required = Required.Always)]
        public int DriverId { get; private set; }

        [JsonProperty(PropertyName = "license_plate", Required = Required.Always)]
        public string LicensePlate { get; set; }

        [JsonProperty(PropertyName = "price_km", Required = Required.Always)]
        public double PricePerKm { get; set; }

        [JsonProperty(PropertyName = "car_type", Required = Required.Always)]
        public string CarType { get; set; }

        [JsonProperty(PropertyName = "car_model", Required = Required.Always)]
        public string CarModel { get; set; }

        [JsonProperty(PropertyName = "nr_of_seats", Required = Required.Always)]
        public int NrOfSeats { get; set; }

        [JsonProperty(PropertyName = "trunk_size", Required = Required.Always)]
        public int TrunkSize { get; set; }

        public Car(int driver_id, string license_plate, double price_km, string car_type, string car_model, int nr_of_seats, int trunk_size)
        {
            DriverId = driver_id;
            LicensePlate = license_plate;
            PricePerKm = price_km;
            CarType = car_type;
            CarModel = car_model;
            NrOfSeats = nr_of_seats;
            TrunkSize = trunk_size;
        }

        [JsonConstructor]
        public Car(int id, int driver_id, string license_plate, double price_km, string car_type, string car_model, int nr_of_seats, int trunk_size)
        {
            Id = id;
            DriverId = driver_id;
            LicensePlate = license_plate;
            PricePerKm = price_km;
            CarType = car_type;
            CarModel = car_model;
            NrOfSeats = nr_of_seats;
            TrunkSize = trunk_size;
        }

        public Car() { }
    }
}

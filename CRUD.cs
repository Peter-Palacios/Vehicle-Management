using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2
{
    interface CRUD
    {
        ICollection<CarInfo> Getinfo();
        void AddRecord(CarInfo obj);
        void DeleteRecord(CarInfo obj);
        CarInfo FindCar(string Vin);
        void UpdateRecord(string vin, CarInfo carinfochanges);
    }

    class CarRepository: CRUD
    {
        PCAD5_CarsEntities entities;
        public CarRepository()
        {
            entities = new PCAD5_CarsEntities();
        }

        public void AddRecord(CarInfo obj)
        {
            entities.CarInfoes.Add(obj);
            entities.SaveChanges();
        }

        public void DeleteRecord(CarInfo obj)
        {
            entities.CarInfoes.Remove(obj);
            entities.SaveChanges();
        }

        public CarInfo FindCar(string vin)
        {
            var car = entities.CarInfoes.First(n => n.Vin == vin);
            if (car!=null)
            {
                return car;
            }
            else
            {
                return null;
            }
        }
        

        public ICollection<CarInfo> Getinfo()
        {
            return entities.CarInfoes.ToList();
        }

        public void UpdateRecord(string vin, CarInfo carinfochanges)
        {
            var carupdate = entities.CarInfoes.Find(vin);
            carupdate.Vin = carinfochanges.Vin;
            carupdate.Make = carinfochanges.Make;
            carupdate.Model = carinfochanges.Model;
            carupdate.Year = Convert.ToInt32(carinfochanges.Year);
            carupdate.Price = Convert.ToDecimal(carinfochanges.Price);
            entities.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace класс_Vehicle
{
    class Vehicle
    {
        private double coordinateX, coordinateY;
        private double price, speed, year_of_construction;
        private string name;

        public double CoordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }

        public double CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Year_of_construction
        {
            get { return year_of_construction; }
            set { year_of_construction = value; }
        }


        //Метод для динамически меняющихся свойств
        public void Coordinate(double CoordinateX, double CoordinateY)
        {
            this.CoordinateX = CoordinateX;
            this.coordinateY = CoordinateY;
        }

        //Метод для динамически меняющихся свойств
        public void SpeedMethod(double Speed)
        {
            this.Speed = Speed;
        }
    }

    class Plane : Vehicle
    {
        public double Height { get; set; }
        public double NumberOfPassengers { get; set; }
        public void HeightMethod(double Height)
        {
            this.Height = Height;
        }
    }

    class Ship : Vehicle
    {
        public double NumberOfPassengers { get; set; }
        public string DestinationPort { get; set; }
    }

    class Car : Vehicle
    {

    }
}


﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : IElectricCar
    {
        public string Model { get ; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public string Start() => "Engine start";

        public string Stop() => "Breaaak!";

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} {this.GetType().Name} {Model} with {Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            return sb.ToString().TrimEnd();
        }
    }
}

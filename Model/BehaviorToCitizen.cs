using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BehaviorToCitizen : BaseEntity
    {
        private Citizen citizen_id;
        private Behavior behavior_id;
        private DateTime date_of_behavior;
        private District district;
        private string description;
        private double latitude;
        private double longitude;

        public DateTime Date_of_behavior { get => date_of_behavior; set => date_of_behavior = value; }
        public string Description { get => description; set => description = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public Citizen Citizen_id { get => citizen_id; set => citizen_id = value; }
        public Behavior Behavior_id { get => behavior_id; set => behavior_id = value; }
        public District District { get => district; set => district = value; }

        public override string ToString() => $"{this.Idx} {this.citizen_id} {this.behavior_id} {this.date_of_behavior} {this.district} {this.description} {this.latitude} {this.longitude}";
    }
}

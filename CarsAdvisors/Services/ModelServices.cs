using CarsAdvisors.Models;
using CarsAdvisors.Services;
using System.Collections.Generic;
using System.Linq;

namespace Cars_Advisors.Services
{
    public class ModelServices:IRepository<Model>
    {
        private readonly Cars Context;

        public ModelServices(Cars Context)
        {
            Context = Context;
        }
        public int Delete(int id)
        {
            Model oldModel = Context.Models.FirstOrDefault(d => d.ID == id);
            Context.Models.Remove(oldModel);
            int raw = Context.SaveChanges();
            return raw;
        }

        public List<Model> GetAll()
        {
            List<Model> Models = Context.Models.ToList();
            return Models;
        }

        public Model GetById(int id)
        {
            return Context.Models.FirstOrDefault(d => d.ID == id);
        }

        public int Insert(Model Newobj)
        {
            Context.Models.Add(Newobj);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Update(int id, Model Newobj)
        {
            Model oldModel = Context.Models.FirstOrDefault(d => d.ID == id);
            oldModel.ModelName = Newobj.ModelName;
            oldModel.Image = Newobj.Image;
            oldModel.Price = Newobj.Price;
            oldModel.Maker_ID = Newobj.Maker_ID;
            oldModel.Body_Style = Newobj.Body_Style;
            oldModel.Transmission = Newobj.Transmission;
            oldModel.Engine_Capacity = Newobj.Engine_Capacity;
            oldModel.Airbags_count = Newobj.Airbags_count;
            oldModel.Fuelconsumption = Newobj.Fuelconsumption;
            oldModel.Horse_power = Newobj.Horse_power;
            oldModel.Luggageboxcapacity= Newobj.Luggageboxcapacity;
            oldModel.Seats_count = Newobj.Seats_count;
            oldModel.Cylinders= Newobj.Cylinders;
            oldModel.Maximum_torque = Newobj.Maximum_torque;
            oldModel.Fuel_Consumption = Newobj.Fuel_Consumption;
            oldModel.Fuel_Type = Newobj.Fuel_Type;
            oldModel.Drive_Type= Newobj.Drive_Type;
            oldModel.Maximum_power = Newobj.Maximum_power;
            oldModel.Acceleration = Newobj.Acceleration;
            oldModel.Maximum_Speed = Newobj.Maximum_Speed;
            oldModel.Fuel_Tank_Capacity=Newobj.Fuel_Tank_Capacity;
            oldModel.Gear_Shifts= Newobj.Gear_Shifts;
            oldModel.folding_for_back_seats=Newobj.folding_for_back_seats;
            oldModel.Paddle_shifters=Newobj.Paddle_shifters;
            oldModel.Leather_Steering_Wheel=Newobj.Leather_Steering_Wheel;
            oldModel.Variable_heated_driver_and_passenger_seat = Newobj.Variable_heated_driver_and_passenger_seat;
            oldModel.Power_Tailgate=Newobj.Power_Tailgate;
            oldModel.Ambient_Lighting=Newobj.Ambient_Lighting;
            oldModel.Steering_Wheel= Newobj.Steering_Wheel;
            oldModel.Number_of_Seats=Newobj.Number_of_Seats;
            oldModel.Rear_parking_sensors=Newobj.Rear_parking_sensors;
            oldModel.Rear_View_Camera=Newobj.Rear_View_Camera;
            oldModel.Passenger_Seat= Newobj.Passenger_Seat;
            oldModel.Parking_Sensors= Newobj.Parking_Sensors;
            oldModel.Electronic_Window= Newobj.Electronic_Window;
            oldModel.Multi_function_steering_wheel=Newobj.Multi_function_steering_wheel;
            oldModel.Leather_Transmission=Newobj.Leather_Transmission;
            oldModel.Back_Holder= Newobj.Back_Holder;
            oldModel.Keyless_Entry= Newobj.Keyless_Entry;
            oldModel.Auto_dimming_mirror=Newobj.Auto_dimming_mirror;
            oldModel.Air_Condition= Newobj.Air_Condition;
            oldModel.Keyless_Start= Newobj.Keyless_Start;
            oldModel.Front_Camera= Newobj.Front_Camera;
            oldModel.Driver_Seat= Newobj.Driver_Seat;
            oldModel.Leather_Seats= Newobj.Leather_Seats;
            oldModel.Center_Lock= Newobj.Center_Lock;
            oldModel.Dashboard=Newobj.Dashboard;
            oldModel.RainSensor= Newobj.RainSensor;
            oldModel.Foglamps= Newobj.Foglamps;
            oldModel.RearLamps= Newobj.RearLamps;
            oldModel.Auto_lighting= Newobj.Auto_lighting;
            oldModel.Wheels_with_tire_size = Newobj.Wheels_with_tire_size;
            oldModel.Panorama_Roof= Newobj.Panorama_Roof;
            oldModel.Auto_Folding_Mirrors=Newobj.Auto_Folding_Mirrors;
            oldModel.Privacy_glass= Newobj.Privacy_glass;
            oldModel.Headlamps= Newobj.Headlamps;
            oldModel.LED_Daytime_running_lamps = Newobj.LED_Daytime_running_lamps;
            oldModel.Light_Sensors= Newobj.Light_Sensors;
            oldModel.Sun_Roof= Newobj.Sun_Roof;
            oldModel.Power_mirrors= Newobj.Power_mirrors;
            oldModel.Rim_Size= Newobj.Rim_Size;
            oldModel.Alarm_Anti_Theft_System=Newobj.Alarm_Anti_Theft_System;
            oldModel.Hill_Assist=Newobj.Hill_Assist;
            oldModel.Speed_Limiter= Newobj.Speed_Limiter;
            oldModel.Automatic_Start_Stop_Function=Newobj.Automatic_Start_Stop_Function;
            oldModel.Tire_Pressure_Monitoring= Newobj.Tire_Pressure_Monitoring;
            oldModel.Electronic_Brake_Force_Distribution = Newobj.Electronic_Brake_Force_Distribution;
            oldModel.Cruise_Control= Newobj.Cruise_Control;
            oldModel.Airbags= Newobj.Airbags;
            oldModel.Electric_Handbrake=Newobj.Electric_Handbrake;
            oldModel.Power_Assisted_Steering=Newobj.Power_Assisted_Steering;
            oldModel.Active_Park_Assist= Newobj.Active_Park_Assist;
            oldModel.Traction_Control= Newobj.Traction_Control;
            oldModel.Anti_Lock_Braking_System = Newobj.Anti_Lock_Braking_System;
            oldModel.AUX=Newobj.AUX;
            oldModel.USB=Newobj.USB;
            oldModel.Multifunction_Steering_Wheel=Newobj.Multifunction_Steering_Wheel;
            oldModel.Navigation_System= Newobj.Navigation_System;
            oldModel.Speakers= Newobj.Speakers;
            oldModel.Bluetooth= Newobj.Bluetooth;
            oldModel.Head_Up_Display= Newobj.Head_Up_Display;
            oldModel.Touch_screen= Newobj.Touch_screen;
            oldModel.Wireless_Charger= Newobj.Wireless_Charger;
            oldModel.Smartphone_Link_Systems= Newobj.Smartphone_Link_Systems;
            oldModel.Luggage_Box_Capacity=Newobj.Luggage_Box_Capacity;
            oldModel.Width=Newobj.Width;
            oldModel.Wheelbase= Newobj.Wheelbase;
            oldModel.Length=Newobj.Length;
            oldModel.Height=Newobj.Height;
            int raw = Context.SaveChanges();
            return raw;
        }
    }
}

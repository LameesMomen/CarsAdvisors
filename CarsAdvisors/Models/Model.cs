using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsAdvisors.Models
{
    public class Model
    {
        public int ID { get; set; }
        [Display(Name = "Model Name")]
        [Required]

        public string ModelName { get; set; }
        [Required]

        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public string Price { get; set; }

        [ForeignKey("Make")]
        [Display(Name = "Make")]
        [Required]

        public int Maker_ID { get; set; }
        public string Image { get; set; }
        [Required]
        public int Year { get; set; }

        #region Main spec
        [Display(Name = "Body Style")]

        public string Body_Style { get; set; }
        public string Transmission { get; set; }
        [Display(Name = "Engine Capacity")]

        public string Engine_Capacity { get; set; }
        [Display(Name = "Airbags count")]

        public int Airbags_count { get; set; }
        [Display(Name = "Fuel consumption")]

        public string Fuelconsumption { get; set; }
        [Display(Name = "Horse power")]

        public string Horse_power { get; set; }
        [Display(Name = "Luggage box capacity")]

        public int Luggageboxcapacity { get; set; }
        [Display(Name = "Seats count")]

        public int Seats_count { get; set; }
        #endregion
        #region Performance Feature
        public int Cylinders { get; set; }
        [Display(Name = "Maximum torque(N.m @RPM)")]

        public string Maximum_torque{ get; set; }
        [Display(Name = "Fuel Consumption(Liter/100 KM)")]

        public string Fuel_Consumption { get; set; }
        [Display(Name = "Fuel Type")]

        public int Fuel_Type { get; set; }
        [Display(Name = "Drive Type")]

        public string Drive_Type { get; set; }
        [Display(Name = "Maximum power(HP @ RPM) ")]

        public string Maximum_power { get; set; }
        [Display(Name = "Acceleration From 0-100 (Km/hr.)")]

        public float Acceleration { get; set; }
        [Display(Name = "Maximum Speed")]

        public int Maximum_Speed { get; set; }
        [Display(Name = "Fuel Tank Capacity")]

        public int Fuel_Tank_Capacity { get; set; }
        [Display(Name = "Gear Shifts")]

        public int Gear_Shifts { get; set; }

        #endregion
        #region Interior Features
        [Display(Name = "folding for back seats")]

        public bool folding_for_back_seats { get; set; }
        [Display(Name = "Paddle shifters")]

        public bool Paddle_shifters { get; set; }
        [Display(Name = "Leather Steering Wheel")]

        public bool Leather_Steering_Wheel { get; set; }
        [Display(Name = "Variable heated driver and passenger seat")]

        public bool Variable_heated_driver_and_passenger_seat { get; set; }
        [Display(Name = "Power Tailgate")]

        public bool Power_Tailgate { get; set; }
        [Display(Name = "Ambient Lighting")]

        public bool Ambient_Lighting { get; set; }
        [Display(Name = "Steering Wheel")]

        public bool Steering_Wheel { get; set; }
        [Display(Name = "Number of Seats")]

        public int Number_of_Seats { get; set; }
        [Display(Name = "Rear parking sensors")]

        public bool Rear_parking_sensors { get; set; }
        [Display(Name = "Rear View Camera")]

        public bool Rear_View_Camera { get; set; }
        [Display(Name = "Passenger Seat")]

        public string Passenger_Seat { get; set; }
        [Display(Name = "Parking Sensors")]

        public bool Parking_Sensors { get; set; }
        [Display(Name = "Electronic Window")]

        public bool Electronic_Window { get; set; }
        [Display(Name = "Multi function steering wheel")]

        public bool Multi_function_steering_wheel { get; set; }
        [Display(Name = "Leather Transmission")]

        public bool Leather_Transmission { get; set; }
        [Display(Name = "Back Holder")]

        public bool Back_Holder { get; set; }
        [Display(Name = "Keyless Entry")]

        public bool Keyless_Entry { get; set; }
        [Display(Name = "Auto dimming mirror")]

        public bool Auto_dimming_mirror { get; set; }
        [Display(Name = "Air Condition")]

        public string Air_Condition { get; set; }
        [Display(Name = "Keyless Start")]

        public bool Keyless_Start { get; set; }
        [Display(Name = "Front Camera")]

        public bool Front_Camera { get; set; }
        [Display(Name = "Driver Seat")]
        public string Driver_Seat { get; set; }
        [Display(Name = "Leather Seats")]

        public bool Leather_Seats { get; set; }
        [Display(Name = "Center Lock")]

        public bool Center_Lock { get; set; }

        public string Dashboard { get; set; }

        #endregion
        #region Extrior Features
        [Display(Name = "Rain Sensor")]

        public bool RainSensor { get; set; }
        [Display(Name = "Fog lamps")]

        public bool Foglamps { get; set; }
        [Display(Name = "Rear Lamps")]

        public string RearLamps { get; set; }
        [Display(Name = "Auto lighting")]

        public bool Auto_lighting { get; set; }
        [Display(Name = "Wheels with tire size")]

        public string Wheels_with_tire_size { get; set; }
        [Display(Name = "Panorama Roof")]


        public bool Panorama_Roof { get; set; }
        [Display(Name = "Auto Folding Mirrors")]

        public bool Auto_Folding_Mirrors { get; set; }
        [Display(Name = "Privacy glass")]

        public bool Privacy_glass { get; set; }
        [Display(Name = "Head lamps")]

        public string Headlamps { get; set; }
        [Display(Name = "LED Daytime running lamps")]

        public bool LED_Daytime_running_lamps { get; set; }
        [Display(Name = "Light Sensors")]

        public bool Light_Sensors { get; set; }
        [Display(Name = "Sun Roof")]

        public bool Sun_Roof { get; set; }
        [Display(Name = "Power mirrors")]

        public bool Power_mirrors { get; set; }
        [Display(Name = "Rim Size")]

        public string Rim_Size { get; set; }
        #endregion
        #region Safety Features
        [Display(Name = "Alarm/Anti Theft System")]

        public bool Alarm_Anti_Theft_System { get; set; }
        [Display(Name = "Hill Assist(HLA)")]

        public bool Hill_Assist { get; set; }
        [Display(Name = "Speed Limiter")]

        public bool Speed_Limiter { get; set; }
        [Display(Name = "Automatic Start/Stop Function")]

        public bool Automatic_Start_Stop_Function { get; set; }
        [Display(Name = "Tire Pressure Monitoring(TPMS)")]

        public bool Tire_Pressure_Monitoring { get; set; }
        [Display(Name = "Electronic Brake Force Distribution(EBD)")]

        public bool Electronic_Brake_Force_Distribution { get; set; }
        [Display(Name = "Cruise Control")]

        public bool Cruise_Control { get; set; }
        [Display(Name = "Number Of Airbags")]

        public int Airbags { get; set; }
        [Display(Name = "Electric Handbrake")]

        public bool Electric_Handbrake { get; set; }
        [Display(Name = "Power Assisted Steering")]

        public string Power_Assisted_Steering { get; set; }
        [Display(Name = "Active Park Assist")]

        public bool Active_Park_Assist { get; set; }
        [Display(Name = "Traction Control")]

        public bool Traction_Control { get; set; }
        [Display(Name = "Anti Lock Braking System(ABS)")]

        public bool Anti_Lock_Braking_System { get; set; }

        #endregion
        #region Multimedia System
        public bool AUX { get; set; }
        public bool USB { get; set; }
        [Display(Name = "Multifunction Steering Wheel")]

        public bool Multifunction_Steering_Wheel { get; set; }
        [Display(Name = "Navigation System")]

        public bool Navigation_System { get; set; }
        public bool Speakers { get; set; }
        public bool Bluetooth { get; set; }
        [Display(Name = "Head Up Display")]

        public bool Head_Up_Display { get; set; }
        [Display(Name = "Touch screen")]

        public bool Touch_screen { get; set; }
        [Display(Name = "Wireless Charger")]

        public bool Wireless_Charger { get; set; }
        [Display(Name = "Smartphone Link Systems")]

        public bool Smartphone_Link_Systems { get; set; }
        #endregion
        #region Dimensions
        [Display(Name = "Luggage Box Capacity")]

        public int Luggage_Box_Capacity { get; set; }
        public int Width { get; set; }
        public int Wheelbase { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }

        #endregion
        public virtual Maker Make { get; set; }
        public virtual List<Compare> Compares { get; set; }
        public virtual List<Image> Images { get; set; }
    }
}

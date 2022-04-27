using CarsAdvisors.Models;
using CarsAdvisors.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace CarsAdvisors.Controllers
{
    [Authorize]

    public class ModelController : Controller
    {
        Cars Context=new Cars();
        private readonly IHostingEnvironment hosting;

        public ModelController(IHostingEnvironment hosting)
        {
            this.hosting = hosting;
        }

        //================== Display All Model================
        public IActionResult Index()
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            ViewData["Make"] = Context.Makers.ToList();
            ViewData["Model"] = Context.Models.ToList();
            var Models = Context.Models.ToList();
            return View(Models);
        }

        //================= Adding new Model ===============
        public IActionResult New()
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            ViewData["Make"] = Context.Makers.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(IFormFile File,Model NewModel)
        {
            if (File != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Images");
                string filename = File.FileName;
                string fullpath = Path.Combine(uploads, filename);
                File.CopyTo(new FileStream(fullpath, FileMode.Create));
                NewModel.Image = filename;
            }

            if (ModelState.IsValid == true)
            {
                Context.Models.Add(NewModel);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Make"] = Context.Makers.ToList();
            return View("New", NewModel);

        }

        //=================Display Model Details==============
        public IActionResult Details(int id)
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            ViewData["Images"] = Context.Images.Where(I => I.Model_ID == id).ToList();
            var Model=Context.Models.Where(m=>m.ID == id).FirstOrDefault();
            return View(Model);
        }

        //=================== Edit Model ==================
        public IActionResult Edit(int id)
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            ViewData["Make"] = Context.Makers.ToList();
            var Model = Context.Models.FirstOrDefault(d => d.ID == id);

            return View(Model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, Model Newobj, IFormFile File)
        {
            if (File != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Images");
                string filename = File.FileName;
                string fullpath = Path.Combine(uploads, filename);
                File.CopyTo(new FileStream(fullpath, FileMode.Create));
                Newobj.Image = filename;
            }

            if (ModelState.IsValid == true)
            {
                Model oldModel = Context.Models.FirstOrDefault(d => d.ID == id);
                oldModel.ModelName = Newobj.ModelName;
                oldModel.Image = Newobj.Image;
                oldModel.Price = Newobj.Price;
                oldModel.Year = Newobj.Year;
                oldModel.Maker_ID = Newobj.Maker_ID;
                oldModel.Body_Style = Newobj.Body_Style;
                oldModel.Transmission = Newobj.Transmission;
                oldModel.Engine_Capacity = Newobj.Engine_Capacity;
                oldModel.Airbags_count = Newobj.Airbags_count;
                oldModel.Fuelconsumption = Newobj.Fuelconsumption;
                oldModel.Horse_power = Newobj.Horse_power;
                oldModel.Luggageboxcapacity = Newobj.Luggageboxcapacity;
                oldModel.Seats_count = Newobj.Seats_count;
                oldModel.Cylinders = Newobj.Cylinders;
                oldModel.Maximum_torque = Newobj.Maximum_torque;
                oldModel.Fuel_Consumption = Newobj.Fuel_Consumption;
                oldModel.Fuel_Type = Newobj.Fuel_Type;
                oldModel.Drive_Type = Newobj.Drive_Type;
                oldModel.Maximum_power = Newobj.Maximum_power;
                oldModel.Acceleration = Newobj.Acceleration;
                oldModel.Maximum_Speed = Newobj.Maximum_Speed;
                oldModel.Fuel_Tank_Capacity = Newobj.Fuel_Tank_Capacity;
                oldModel.Gear_Shifts = Newobj.Gear_Shifts;
                oldModel.folding_for_back_seats = Newobj.folding_for_back_seats;
                oldModel.Paddle_shifters = Newobj.Paddle_shifters;
                oldModel.Leather_Steering_Wheel = Newobj.Leather_Steering_Wheel;
                oldModel.Variable_heated_driver_and_passenger_seat = Newobj.Variable_heated_driver_and_passenger_seat;
                oldModel.Power_Tailgate = Newobj.Power_Tailgate;
                oldModel.Ambient_Lighting = Newobj.Ambient_Lighting;
                oldModel.Steering_Wheel = Newobj.Steering_Wheel;
                oldModel.Number_of_Seats = Newobj.Number_of_Seats;
                oldModel.Rear_parking_sensors = Newobj.Rear_parking_sensors;
                oldModel.Rear_View_Camera = Newobj.Rear_View_Camera;
                oldModel.Passenger_Seat = Newobj.Passenger_Seat;
                oldModel.Parking_Sensors = Newobj.Parking_Sensors;
                oldModel.Electronic_Window = Newobj.Electronic_Window;
                oldModel.Multi_function_steering_wheel = Newobj.Multi_function_steering_wheel;
                oldModel.Leather_Transmission = Newobj.Leather_Transmission;
                oldModel.Back_Holder = Newobj.Back_Holder;
                oldModel.Keyless_Entry = Newobj.Keyless_Entry;
                oldModel.Auto_dimming_mirror = Newobj.Auto_dimming_mirror;
                oldModel.Air_Condition = Newobj.Air_Condition;
                oldModel.Keyless_Start = Newobj.Keyless_Start;
                oldModel.Front_Camera = Newobj.Front_Camera;
                oldModel.Driver_Seat = Newobj.Driver_Seat;
                oldModel.Leather_Seats = Newobj.Leather_Seats;
                oldModel.Center_Lock = Newobj.Center_Lock;
                oldModel.Dashboard = Newobj.Dashboard;
                oldModel.RainSensor = Newobj.RainSensor;
                oldModel.Foglamps = Newobj.Foglamps;
                oldModel.RearLamps = Newobj.RearLamps;
                oldModel.Auto_lighting = Newobj.Auto_lighting;
                oldModel.Wheels_with_tire_size = Newobj.Wheels_with_tire_size;
                oldModel.Panorama_Roof = Newobj.Panorama_Roof;
                oldModel.Auto_Folding_Mirrors = Newobj.Auto_Folding_Mirrors;
                oldModel.Privacy_glass = Newobj.Privacy_glass;
                oldModel.Headlamps = Newobj.Headlamps;
                oldModel.LED_Daytime_running_lamps = Newobj.LED_Daytime_running_lamps;
                oldModel.Light_Sensors = Newobj.Light_Sensors;
                oldModel.Sun_Roof = Newobj.Sun_Roof;
                oldModel.Power_mirrors = Newobj.Power_mirrors;
                oldModel.Rim_Size = Newobj.Rim_Size;
                oldModel.Alarm_Anti_Theft_System = Newobj.Alarm_Anti_Theft_System;
                oldModel.Hill_Assist = Newobj.Hill_Assist;
                oldModel.Speed_Limiter = Newobj.Speed_Limiter;
                oldModel.Automatic_Start_Stop_Function = Newobj.Automatic_Start_Stop_Function;
                oldModel.Tire_Pressure_Monitoring = Newobj.Tire_Pressure_Monitoring;
                oldModel.Electronic_Brake_Force_Distribution = Newobj.Electronic_Brake_Force_Distribution;
                oldModel.Cruise_Control = Newobj.Cruise_Control;
                oldModel.Airbags = Newobj.Airbags;
                oldModel.Electric_Handbrake = Newobj.Electric_Handbrake;
                oldModel.Power_Assisted_Steering = Newobj.Power_Assisted_Steering;
                oldModel.Active_Park_Assist = Newobj.Active_Park_Assist;
                oldModel.Traction_Control = Newobj.Traction_Control;
                oldModel.Anti_Lock_Braking_System = Newobj.Anti_Lock_Braking_System;
                oldModel.AUX = Newobj.AUX;
                oldModel.USB = Newobj.USB;
                oldModel.Multifunction_Steering_Wheel = Newobj.Multifunction_Steering_Wheel;
                oldModel.Navigation_System = Newobj.Navigation_System;
                oldModel.Speakers = Newobj.Speakers;
                oldModel.Bluetooth = Newobj.Bluetooth;
                oldModel.Head_Up_Display = Newobj.Head_Up_Display;
                oldModel.Touch_screen = Newobj.Touch_screen;
                oldModel.Wireless_Charger = Newobj.Wireless_Charger;
                oldModel.Smartphone_Link_Systems = Newobj.Smartphone_Link_Systems;
                oldModel.Luggage_Box_Capacity = Newobj.Luggage_Box_Capacity;
                oldModel.Width = Newobj.Width;
                oldModel.Wheelbase = Newobj.Wheelbase;
                oldModel.Length = Newobj.Length;
                oldModel.Height = Newobj.Height;
                int raw = Context.SaveChanges();
                Context.SaveChanges();
                return Redirect($"/Model/Details/{id}");

            }
            ViewData["Make"] = Context.Makers.ToList();
            return View("Edit", Newobj);
        }

        //============== Delete Model =============

        public IActionResult Delete(int id)
        {
            Model oldModel = Context.Models.FirstOrDefault(d => d.ID == id);
            Context.Models.Remove(oldModel);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Modellist(string id)
        {
            var model = Context.Models.Include(m=>m.Make).Where(m=>m.Make.MakerName==id).ToList();
            return PartialView("_Selectlist", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Search(SearchViewModel search)
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            ViewData["Make"] = Context.Makers.ToList();
            ViewData["search"] = Context.Models.Include(m => m.Make).Where(m => (m.Make.MakerName.Contains(search.Make) || m.ModelName.Contains(search.Model))).FirstOrDefault();
            var model=Context.Models.Include(m=>m.Make).Where(m=>(m.Make.MakerName.Contains(search.Make) || m.ModelName .Contains( search.Model))).ToList();
            var modelcount=Context.Models.Include(m=>m.Make).Where(m=>(m.Make.MakerName.Contains(search.Make) || m.ModelName .Contains( search.Model))).Count();
            if (modelcount !=0)
            {
            return View(model);
            }
            else
            {
                TempData["error"] = "error";
                return RedirectToAction("Index");

            }
        }
    }
}

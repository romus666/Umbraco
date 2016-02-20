using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace vs.models
{
    public class Workouts
    {
        public List<Workout> Workoutlist { get; set; } 
    }
    public class Workout
    {
        public string Name { get; set; }
        public List<Excercise> Exercises { get; set; } 

    }

}
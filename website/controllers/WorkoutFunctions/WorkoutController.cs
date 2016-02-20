using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using vs.models;

namespace vs.controllers
{
    public class WorkoutController : SurfaceController
    {
        // GET: workout
        public ActionResult Index()
        {
            var mymodel = new Workouts();
            var workouts = Umbraco.Content(1058);
            var typedworkouts = Umbraco.TypedContent(1058);
            mymodel.Workoutlist = new List<Workout>();
            foreach (var workout in workouts.Children)
            {
                var customWorkout = new Workout();
                customWorkout.Exercises = new List<Excercise>();
                foreach (var exercise in workout.Children)
                {
                    var customExcercise = new Excercise();
                    customExcercise.Name = exercise.Name;
                    customWorkout.Exercises.Add(customExcercise);
                }
                customWorkout.Name = workout.Name;
                mymodel.Workoutlist.Add(customWorkout);
            }
            
            return PartialView("/Views/WorkoutFunctions/workout/Index.cshtml", mymodel);
        }

        [HttpGet]
        public JsonResult GetWorkouts()
        {
            var mymodel = new Workouts();
            mymodel.Workoutlist = new List<Workout>();
            mymodel.Workoutlist.Add(new Workout() { Name = "JOHAN" });
            mymodel.Workoutlist.Add(new Workout() { Name = "Berra" });
            return Json(mymodel, JsonRequestBehavior.AllowGet);
        }
    }
}
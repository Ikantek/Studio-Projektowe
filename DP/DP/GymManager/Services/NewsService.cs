using GymManager.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GymManager.Models.Enums;

namespace GymManager.Services
{
    public class ExercisesService
    {
        public static List<List<Exercise>> PrepareExercises(DbContext dbContext)
        {
            var tableBPS = dbContext.Set<Exercise>().Where(x => x.ExcerciseName == (int)ExercisesEnum.BenchPressFlat).OrderByDescending(x => x.Result).Take(10).ToList();
            var tableDL = dbContext.Set<Exercise>().Where(x => x.ExcerciseName == (int)ExercisesEnum.Deadlift).OrderByDescending(x => x.Result).Take(10).ToList();
            var tableOHP = dbContext.Set<Exercise>().Where(x => x.ExcerciseName == (int)ExercisesEnum.OHP).OrderByDescending(x => x.Result).Take(10).ToList();
            var tableBS = dbContext.Set<Exercise>().Where(x => x.ExcerciseName == (int)ExercisesEnum.BarbellSquat).OrderByDescending(x => x.Result).Take(10).ToList();
            var tableWPU = dbContext.Set<Exercise>().Where(x => x.ExcerciseName == (int)ExercisesEnum.WeightPullUp).OrderByDescending(x => x.Result).Take(10).ToList();
            var finalTable = new List<List<Exercise>> { tableBPS, tableDL, tableOHP, tableBS, tableWPU };
            return finalTable;
        }
    }
}

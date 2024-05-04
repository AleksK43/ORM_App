using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity; 


namespace ORM_App.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        [Display(Name ="Obciążenie"),Range(1,250)]
        public int Weight { get; set; }
        [Display(Name = "Liczba Powtórzeń"), Range(1,100)]
        public int NumOfReps { get; set; }
        [Display(Name = "Liczba Serii"), Range(1,100)]
        public int NumOfSeries { get; set; }
        
        public int  ExerciseTypeId { get; set; }
        [Display(Name = "Rodaj Ćwiczeń")]
        public virtual ExerciseType? ExerciseType { get; set; }
        [Display(Name = "Sesja")]
        public int SessionId { get; set; }
        
        public virtual Session? Session { get; set; }
        public virtual IdentityUser? User { get; set;  }
    }
}

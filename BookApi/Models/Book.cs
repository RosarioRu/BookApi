using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 
using System;

namespace BookApi.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; init; }

        [Required]
        public string Reviews { get; set; }
        
        // [Required]
        // public int Rating { get; set; }
        // [Required]
        public int SingleRating {get; set;} //hidden/not displayed to user?


        public List<int> theRatings {get;}

        

        // public Book()
        // {
        //   theRatings = new List<int>();
        // }

        // public List<int> AllRatings {get 
        //   { 
        //     theRatings.Add(SingleRating);
        //     return theRatings;
        //   } 
        // }

        public List<int> AllRatings () 
          { 
            theRatings.Add(SingleRating);
            return theRatings;
          } 

          // public void AllRatings () 
          // { 
          //   theRatings.Add(SingleRating);
          // } 
        
        
    }
}
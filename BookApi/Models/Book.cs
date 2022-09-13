using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 

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
        [Required]
        public int SingleRating {get; set;} //hidden/not displayed to user?

        public List<int> AllRatings {get 
          { 
            List<int> theRatings = new List<int>();
            theRatings.Add(SingleRating);
            return theRatings;

            // return 1+ SingleRating;
          }
        }

        //  public string FullName { get { return $"{FirstName} {LastName}"; } }

        // public string FullName => $"{FirstName} {LastName}";

        // public List<int> AllRatings 
        // {
        //   AllRatings.Add( $"{SingleRating}" );
        //   get{ return $"{AllRatings}"}; 
        // }

    }
}
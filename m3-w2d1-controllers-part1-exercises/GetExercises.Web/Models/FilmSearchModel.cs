using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetExercises.Web.Models
{
    public class FilmSearchModel
    {
        private int? _maxLength;
        private int? _minLength;

        public int MaxLength
        {
            get
            {
                if (_maxLength.HasValue)
                {
                    return (int)_maxLength;
                }
                return int.MaxValue;
            }
            set
            {
                _maxLength = value;
            }
               
        }
        public int MinLength
        {
            get
            {
                if (_minLength.HasValue)
                {
                    return (int)_minLength;
                }
                return 0;
            }
            set
            {
                _minLength = value;
            }

        }

        public string Genre { get; set; }
    }
}
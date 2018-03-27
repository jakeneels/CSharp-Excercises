using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetExercises.Web.Models
{
    public class IndexData
    {
        public IList<string> Categorys { get; set; }
        public IList<Film> Films { get; set; }
    }
}
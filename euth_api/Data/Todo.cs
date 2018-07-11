using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace euth_api.Data
{
    public class Todo
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDone { get; set; }

    }
}
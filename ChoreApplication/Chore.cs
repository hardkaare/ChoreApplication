using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    class Chore
    {
        //Properties
        private string name { get; set; }
        private string description { get; set; }
        private int points { get; set; }
        private string assignment { get; set; }

        public Chore(string _name, string _desc, int _points, string _assignment)
        {
            name = _name;
            description = _desc;
            points = _points;
            assignment = _assignment;
        }

        //ToString override. Lists all properties.
        public override string ToString()
        {
            return string.Format("Chore: {0}, description: {1}, points: {2}, assignment: {3}", 
                name, description, points, assignment);
        }
    }
}

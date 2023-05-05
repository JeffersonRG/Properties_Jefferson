using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_Jefferson
{
    class Car
    {
        //This is a backing field for model
        private string model;

        //This is a property for model
        public string Model { get { return model; } set { model = value; } }

        //This is an automatic property for the make
        public string Make { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace structuri
{
    internal class Camera
    {
        public int numar;
        public string tip;
        public bool ocupata;

        public string DescriereCamera()
        {
            string text = "";
            text += "Camera de tip " + tip + " \n";
            text += "Camera cu nuamrul " + numar;
            return text;
        }

        
    }
}

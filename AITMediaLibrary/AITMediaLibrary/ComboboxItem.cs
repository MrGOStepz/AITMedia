using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AITMediaLibrary
{
    public class ComboboxItem
    {
        public String Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
        
    }
}

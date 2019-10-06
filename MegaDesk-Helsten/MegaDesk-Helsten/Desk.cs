using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MegaDesk_Helsten
{
    class Desk
    {
        public enum DesktopMaterial {[Description("Laminate Oak")] LaminateOak, Rosewood, Veneer, Pine };
        public Int32 widthMin = 24;
        public Int32 widthMax = 96;
        public Int32 depthMin = 12;
        public Int32 depthMax = 48;
        public Int32 drawerMin = 0;
        public Int32 drawerMax = 7;
    }
}

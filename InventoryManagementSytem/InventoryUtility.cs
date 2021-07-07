using System.Collections.Generic;


namespace InventoryManagementSytem
{
    public class InventoryUtility
    {
        /// <summary>
        /// Gets or sets the Ricelist
        /// </summary> 

        public List<Rice> RiceList { get; set; }
        /// <summary>
        /// Gets or sets the Pulselist
        /// </summary> 

        public List<Pulse> PulseList { get; set; }
        /// <summary>
        /// Gets or sets the Wheatlist
        /// </summary> 

        public List<Wheat> WheatList { get; set; }

        //Creating class for the inventory lists
        public class Rice
        {
            /// <summary>
            /// Gets or sets the name
            /// </summary> 
            public string Name { get; set; }
            /// <summary>
            /// Gets or sets the price
            /// </summary> 
            public int Price { get; set; }
            /// <summary>
            /// Gets or sets the kg
            /// </summary> 
            public int Kg { get; set; }

        }
        public class Wheat
        {
            /// <summary>
            /// Gets or sets the name
            /// </summary> 
            public string Name { get; set; }
            /// <summary>
            /// Gets or sets the price
            /// </summary> 
            public int Price { get; set; }
            /// <summary>
            /// Gets or sets the kg
            /// </summary> 
            public int Kg { get; set; }
        }

        public class Pulse
        {
            /// <summary>
            /// Gets or sets the name
            /// </summary> 
            public string Name { get; set; }
            /// <summary>
            /// Gets or sets the price
            /// </summary> 
            public int Price { get; set; }
            /// <summary>
            /// Gets or sets the kg
            /// </summary> 
            public int Kg { get; set; }
        }
    }




}

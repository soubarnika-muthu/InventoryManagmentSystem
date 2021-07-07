using System;
using System.Collections.Generic;


namespace InventoryManagementSytem
{
    class InventoryManager
    {
        public List<InventoryUtility.Rice> AddToInventory(List<InventoryUtility.Rice> ricelist)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();


            Console.WriteLine("Enter Name Of Rice:");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter price Of Rice:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight in Kg Of Rice:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            ricelist.Add(utility);
            Console.WriteLine("New Rice added to the list");
            return ricelist;
        }
        public List<InventoryUtility.Pulse> AddToInventory(List<InventoryUtility.Pulse> pulse)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();


            Console.WriteLine("Enter Name Of Pulse:");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter price Of pulse:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight in Kg Of pulse:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            pulse.Add(utility);
            Console.WriteLine("New pulse added to the list");
            return pulse;
        }
        public List<InventoryUtility.Wheat> AddToInventory(List<InventoryUtility.Wheat> wheat)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();


            Console.WriteLine("Enter Name Of Wheat:");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter price Of Wheat:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight in Kg Of Wheat:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            wheat.Add(utility);
            Console.WriteLine("New wheat added to the list");
            return wheat;
        }
        public List<InventoryUtility.Rice> UpdateToInventory(List<InventoryUtility.Rice> rice)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter Name or Rice to be Updated:");
            string Name = Console.ReadLine();
            rice.Remove(rice.Find(ut => ut.Name.Equals(Name)));

            Console.WriteLine("Enter Name Of Rice:");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter price Of Rice:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight in Kg Of Rice:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            rice.Add(utility);
            Console.WriteLine("Updated Rice List");
            return rice;
        }
        public List<InventoryUtility.Pulse> UpdateToInventory(List<InventoryUtility.Pulse> pulse)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();

            Console.WriteLine("Enter Name of pulse to be Updated:");
            string Name = Console.ReadLine();
            pulse.Remove(pulse.Find(ut => ut.Name.Equals(Name)));


            Console.WriteLine("Enter Name Of Pulse:");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter price Of pulse:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight in Kg Of pulse:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            pulse.Add(utility);
            Console.WriteLine("Updated Pulse List");
            return pulse;
        }
        public List<InventoryUtility.Wheat> UpdateToInventory(List<InventoryUtility.Wheat> wheat)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();

            Console.WriteLine("Enter Name of wheat to be Updated:");
            string Name = Console.ReadLine();
            wheat.Remove(wheat.Find(ut => ut.Name.Equals(Name)));


            Console.WriteLine("Enter Name Of Wheat:");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter price Of Wheat:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight in Kg Of Wheat:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            wheat.Add(utility);
            Console.WriteLine("Updated wheat List");
            return wheat;
        }
        public List<InventoryUtility.Rice> RemoveFromInventory(List<InventoryUtility.Rice> rice)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter Name or Rice to be deleted:");
            string Name = Console.ReadLine();
            rice.Remove(rice.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("Deleted from  Rice List");
            return rice;
        }
        public List<InventoryUtility.Pulse> RemoveFromInventory(List<InventoryUtility.Pulse> pulse)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();

            Console.WriteLine("Enter Name of pulse to be Updated:");
            string Name = Console.ReadLine();
            pulse.Remove(pulse.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("Deleted from  Pulse List");
            return pulse;
        }
        public List<InventoryUtility.Wheat> RemoveFromInventory(List<InventoryUtility.Wheat> wheat)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();

            Console.WriteLine("Enter Name of wheat to be Updated:");
            string Name = Console.ReadLine();
            wheat.Remove(wheat.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("Deleted from  Wheat List");
            return wheat;
        }
        public void DisplayInventory(List<InventoryUtility.Rice> rice)
        {
            Console.WriteLine("***********Rice Inventory*************");
            string ricestring = string.Empty;
            int totalInventoryRice = 0;
            //iterates rice list by Inventor Utility.Rice data type
            foreach (InventoryUtility.Rice i in rice)
            {
                ricestring = "\nName=" + i.Name + "\nWeight in kg=" + i.Kg + "\nPrice=" + i.Price;
                totalInventoryRice += ManageInventory(i.Kg, i.Price);
                Console.WriteLine(ricestring);
                Console.WriteLine("Total inventory rice cost" + totalInventoryRice);
            }

        }
        public void DisplayInventory(List<InventoryUtility.Pulse> pulse)
        {
            Console.WriteLine("***********Rice Inventory*************");
            string pulsestring = string.Empty;
            int totalInventoryPulse = 0;
            //iterates rice list by Inventor Utility.Rice data type
            foreach (InventoryUtility.Pulse i in pulse)
            {
                pulsestring = "\nName=" + i.Name + "\nWeight in kg=" + i.Kg + "\nPrice=" + i.Price;
                totalInventoryPulse += ManageInventory(i.Kg, i.Price);
                Console.WriteLine(pulsestring);
                Console.WriteLine("Total inventory rice cost" + totalInventoryPulse);
            }

        }
        public void DisplayInventory(List<InventoryUtility.Wheat> wheat)
        {
            Console.WriteLine("***********wheat Inventory*************");
            string wheatstring = string.Empty;
            int totalInventoryWheat = 0;
            //iterates rice list by Inventor Utility.Rice data type
            foreach (InventoryUtility.Wheat i in wheat)
            {
                wheatstring = "\nName=" + i.Name + "\nWeight in kg=" + i.Kg + "\nPrice=" + i.Price;
                totalInventoryWheat += ManageInventory(i.Kg, i.Price);
                Console.WriteLine(wheatstring);
                Console.WriteLine("Total inventory rice cost" + totalInventoryWheat);
            }

        }
        public int ManageInventory(int kg, int price)
        {
            return kg * price;
        }



    }
}

using System;
using System.IO;
using Newtonsoft.Json;
namespace InventoryManagementSytem.Inventory
{
    /// <summary>
    /// this is class Inventory
    /// </summary>


    public class Inventory
    {
        public int exit;


        public static void JsonDeserilaize()
        {
            //cretate object for inventory manager
            InventoryManager manager = new InventoryManager();
            string filepath = "C:/Users/hp/source/repos/ObjectOrientedPrograms/ObjectOrientedPrograms/JsonData.json";
            //deserialization
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(filepath));
            int exit = 1;
            do
            {
                Console.WriteLine("**********Main Menu************");
                Console.WriteLine("1.Display Inventory\n2.Add to Inventory\n3.Remove from Inventory\n4.Update to Inventory\n5.Press 0 to Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("1.Rice\n2.Pulse\n3.Wheat\nEnter Your Option:");
                        int displayOption = Convert.ToInt32(Console.ReadLine());
                        switch (displayOption)
                        {
                            case 1:
                                //display inventory list of rice
                                manager.DisplayInventory(utility.RiceList);
                                break;
                            case 2:
                                //display inventory list of pulse
                                manager.DisplayInventory(utility.PulseList);
                                break;
                            case 3:
                                //display inventory list of wheat
                                manager.DisplayInventory(utility.WheatList);
                                break;
                            default:
                                Console.WriteLine("Enter Valid Choice:");
                                break;

                        }
                        break;

                    case 2:
                        Console.WriteLine("1.Add records to Rice\n2..Add records to Pulse\n3..Add records to Wheat\nEnter Your Option:");
                        int displayOption1 = Convert.ToInt32(Console.ReadLine());
                        switch (displayOption1)
                        {
                            case 1:
                                //add  records to inventory list 
                                utility.RiceList = manager.AddToInventory(utility.RiceList);
                                //update added records to json file by serializing 
                                File.WriteAllText(filepath, JsonConvert.SerializeObject(utility));
                                break;
                            case 2:

                                //add  records to inventory list 
                                utility.PulseList = manager.AddToInventory(utility.PulseList);
                                //update added records to json file by serializing 
                                File.WriteAllText(filepath, JsonConvert.SerializeObject(utility));
                                break;

                            case 3:
                                //add  records to inventory list 
                                utility.WheatList = manager.AddToInventory(utility.WheatList);
                                //update added records to json file by serializing 
                                File.WriteAllText(filepath, JsonConvert.SerializeObject(utility));
                                break;

                            default:
                                Console.WriteLine("Enter Valid Choice:");
                                break;

                        }
                        break;
                    case 3:
                        Console.WriteLine("1.Remove records from Rice\n2.Remove records from Pulse\n3.Remove records from Wheat\nEnter Your Option:");
                        int displayOption2 = Convert.ToInt32(Console.ReadLine());
                        switch (displayOption2)
                        {
                            case 1:
                                //display inventory list of rice
                                manager.DisplayInventory(utility.RiceList);
                                //remove records from inventory list 
                                utility.RiceList = manager.RemoveFromInventory(utility.RiceList);
                                //update to json file by serializing 
                                File.WriteAllText(filepath, JsonConvert.SerializeObject(utility));

                                break;
                            case 2:

                                //display inventory list of pulses
                                manager.DisplayInventory(utility.PulseList);
                                //remove records from inventory list 
                                utility.PulseList = manager.RemoveFromInventory(utility.PulseList);
                                //update to json file by serializing 
                                File.WriteAllText(filepath, JsonConvert.SerializeObject(utility));
                                break;
                            case 3:

                                //display inventory list of Wheat
                                manager.DisplayInventory(utility.WheatList);
                                //remove records from inventory list 
                                utility.WheatList = manager.RemoveFromInventory(utility.WheatList);
                                //update to json file by serializing 
                                File.WriteAllText(filepath, JsonConvert.SerializeObject(utility));
                                break;
                            default:
                                Console.WriteLine("Enter Valid Choice:");
                                break;

                        }
                        break;
                    case 4:
                        Console.WriteLine("1.Update record to Rice\n2.Update record to Pulse\n3.Update record to Wheat\nEnter Your Option:");
                        int displayOption3 = Convert.ToInt32(Console.ReadLine());
                        switch (displayOption3)
                        {
                            case 1:
                                //display inventory list of rice
                                manager.DisplayInventory(utility.RiceList);
                                //remove records from inventory list 
                                utility.RiceList = manager.UpdateToInventory(utility.RiceList);
                                //update to json file by serializing 
                                File.WriteAllText(filepath, JsonConvert.SerializeObject(utility));

                                break;
                            case 2:

                                //display inventory list of pulses
                                manager.DisplayInventory(utility.PulseList);
                                //remove records from inventory list 
                                utility.PulseList = manager.UpdateToInventory(utility.PulseList);
                                //update to json file by serializing 
                                File.WriteAllText(filepath, JsonConvert.SerializeObject(utility));
                                break;
                            case 3:

                                //display inventory list of Wheat
                                manager.DisplayInventory(utility.WheatList);
                                //remove records from inventory list 
                                utility.WheatList = manager.UpdateToInventory(utility.WheatList);
                                //update to json file by serializing 
                                File.WriteAllText(filepath, JsonConvert.SerializeObject(utility));
                                break;
                            default:
                                Console.WriteLine("Enter Valid Choice:");
                                break;

                        }
                        break;
                    default:
                        Console.WriteLine("Enter Valid Choice:");
                        break;

                }
                if (exit == 0)
                    break;

            } while (exit != 0);
            








        }
    }






}


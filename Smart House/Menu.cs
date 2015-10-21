using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class Menu
    {
        IDictionary<string, Device> deviceDict = new Dictionary<string, Device>();
        public void Start()
        {
            deviceDict.Add("lamp1", new Lamp(false, Level.Low));
            deviceDict.Add("tv1", new TV(false, 5, 10));
            deviceDict.Add("heater1", new Heater(false, Level.Low));
            deviceDict.Add("signalization", new Signalization(true));

            while (true)
            {
                Console.Clear();
                foreach (var dev in deviceDict)
                {
                    Console.WriteLine(dev.Key + dev.Value.ToString());
                }

                Console.WriteLine("Введите команду вида: действие - тип устройства - имя");

                string[] command = Console.ReadLine().Split(' ');

                if (command[0].ToLower() == "exit")
                {
                    return;
                }
                if (command[0].ToLower() == "help")
                {
                    Help();
                    continue;
                }

                if (command.Length != 3 && command.Length != 2 )
                {
                    Console.WriteLine("Введена неверная команда. Для справки введите help ");
                    Console.WriteLine("Нажмите Enter для продолжения...");
                    Console.ReadLine();
                    continue;
                }
                if (command[0].ToLower() == "help")
                {
                    Help();
                    continue;
                }


                if (command[0] == "add")
                {
                    try
                    {
                        if (CheckExistName(command[2]) == false)
                        {

                            if (command[1] == "lamp")
                            {
                                AddLamp(command[2]);
                            }
                            if (command[1] == "tv")
                            {
                                AddTV(command[2]);
                            }
                            if (command[1] == "heater")
                            {
                                AddHeater(command[2]);
                            }
                            if (command[1] == "AirCon")
                            {
                                AddAirCon(command[2]);
                            }
                           


                        }
                    }
                    catch(Exception){}
                        finally
                    {
                        
                    Console.WriteLine("Введена неверная команда. Для справки введите help ");
                    Console.WriteLine("Нажмите Enter для продолжения...");
                    Console.ReadLine();
                    
                    }
                   
                }

                switch (command[0].ToLower())
                {
                    case "del":
                        deviceDict.Remove(command[1]);
                        break;
                    case "on":
                        ((ISwitchable)deviceDict[command[1]]).SetOn();
                        break;
                    case "off":
                        ((ISwitchable)deviceDict[command[1]]).SetOff();
                        break;
                    case "upchannel":
                        if (deviceDict[command[1]] is IChannelable)
                        {
                            ((IChannelable)deviceDict[command[1]]).SetChannelUp();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "downchannel":
                        if (deviceDict[command[1]] is IChannelable)
                        {
                            ((IChannelable)deviceDict[command[1]]).SetChannelDown();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "upvolume":
                        if (deviceDict[command[1]] is IVolumable)
                        {
                            ((IVolumable)deviceDict[command[1]]).SetVolumeUp();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "downvolume":
                        if (deviceDict[command[1]] is IVolumable)
                        {
                            ((IVolumable)deviceDict[command[1]]).SetVolumeDown();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "brightlow":
                        if (deviceDict[command[1]] is IBrightable)
                        {
                            ((IBrightable)deviceDict[command[1]]).SetBrightLow();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "brightmed":
                        if (deviceDict[command[1]] is IBrightable)
                        {
                            ((IBrightable)deviceDict[command[1]]).SetBrightMed();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "brighthigh":
                        if (deviceDict[command[1]] is IBrightable)
                        {
                            ((IBrightable)deviceDict[command[1]]).SetBrightHigh();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "coollow":
                        if (deviceDict[command[1]] is ICoolable)
                        {
                            ((ICoolable)deviceDict[command[1]]).SetCoolLow();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "coolmed":
                        if (deviceDict[command[1]] is ICoolable)
                        {
                            ((ICoolable)deviceDict[command[1]]).SetCoolMed();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "coolhigh":
                        if (deviceDict[command[1]] is ICoolable)
                        {
                            ((ICoolable)deviceDict[command[1]]).SetCoolHigh();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "heatlow":
                        if (deviceDict[command[1]] is IHeatable)
                        {
                            ((IHeatable)deviceDict[command[1]]).SetHeatLow();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "heatmed":
                        if (deviceDict[command[1]] is IHeatable)
                        {
                            ((IHeatable)deviceDict[command[1]]).SetHeatMed();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;
                    case "heathigh":
                        if (deviceDict[command[1]] is IHeatable)
                        {
                            ((IHeatable)deviceDict[command[1]]).SetHeatHigh();
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте другое устройство");
                            Console.ReadKey();
                        }
                        break;

                }
            }
        }

        public void Help()
        {
            Console.WriteLine("Доступные устройства: TV, AirCon, Heater, Lamp, Signalization");
            Console.WriteLine("Доступные команды: ");
            Console.WriteLine("add device");
            Console.WriteLine("del device");
            Console.WriteLine("__________");
            Console.WriteLine("on device");
            Console.WriteLine("off device");
            Console.WriteLine("__________");
            Console.WriteLine("brightlow lamp");
            Console.WriteLine("brightmed lamp");
            Console.WriteLine("brighthigh lamp");
            Console.WriteLine("__________");
            Console.WriteLine("upvolume tv");
            Console.WriteLine("downvolume tv");
            Console.WriteLine("upchannel tv");
            Console.WriteLine("downchannel tv");
            Console.WriteLine("__________");
            Console.WriteLine("coollow AirCon");
            Console.WriteLine("coolmed AirCon");
            Console.WriteLine("coolhigh AirCon");
            Console.WriteLine("__________");
            Console.WriteLine("heatlow heater");
            Console.WriteLine("heatmed heater");
            Console.WriteLine("heathigh heater");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        public void AddLamp(string name)
        {
            deviceDict.Add(name, new Lamp(false, Level.Low));
        }
        public void AddTV(string name)
        {
            deviceDict.Add(name, new TV(false, 1, 10));
        }
        public void AddHeater(string name)
        {
            deviceDict.Add(name, new Heater(false, Level.Low));
        }
        public void AddAirCon(string name)
        {
            deviceDict.Add(name, new AirCon(false, Level.Low));
        }
       
        
        public bool CheckExistName(string name)
        {
            if (deviceDict.ContainsKey(name))
            {
                Console.WriteLine("Имя уже существует, попробуйте другое");
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                return true;
            }
            return false;
        }
    }
}

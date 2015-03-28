using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.IO;
namespace Ejercicios
{
    class Bluetooth
    {
        public void Run()
        {
            var client = new BluetoothClient();
            Console.WriteLine("This device's name is {0}", BluetoothRadio.PrimaryRadio.Name);
            var peers = client.DiscoverDevices();
            if (peers == null || peers.Length == 0)
            {
                Console.WriteLine("No devices found");
                return;
            }
            
            foreach (var device in peers)
            {
                device.Refresh();
                int i = 0;
                while (device.DeviceName.Contains(":") && ++i <= 15)
                    device.Refresh();
                Console.WriteLine("Device name: {0}", device.DeviceName);
            }
        }
    }
}

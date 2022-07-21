using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using MySql.Data.MySqlClient;
        String host = System.Net.Dns.GetHostName();
        Console.WriteLine("Имя ПК: " + host);
        Console.WriteLine("Список доступных IP: ");
        for (int z = 0; z < 4; z++)
        {
            System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[z];
            Console.WriteLine(ip);
        };
        Console.ReadLine();
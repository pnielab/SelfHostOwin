﻿using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace SelfHostOwin
{
    internal class Program
    {
        static void Main() 
        { 
            string baseAddress = "http://localhost:8080/"; 
            using (WebApp.Start<Startup>(url: baseAddress)) 
            { 
                // Create HttpClient and make a request to api/values 
                HttpClient client = new HttpClient(); 
                HttpResponseMessage response = client.GetAsync(baseAddress + "api/devices").Result; 
                Console.WriteLine(response); 
                Console.WriteLine(response.Content.ReadAsStringAsync().Result); 
                Console.ReadLine(); 
            } 
        }
    }
}
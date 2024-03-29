﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TaskGrab.Data;
using TaskGrab.Navigation;

namespace TaskGrab
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            using (TaskGrabContext dbContext = new TaskGrabContext())
            {
                dbContext.Database.Migrate();
            }
        }
    }
}

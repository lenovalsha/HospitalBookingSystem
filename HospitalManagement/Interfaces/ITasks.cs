﻿using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface ITasks
    {
        ICollection<Tasks> GetTasks();
    }
}

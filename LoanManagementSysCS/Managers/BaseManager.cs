using LoanManagementSys.Managers;
using LoanManagementSys;
using System;
using System.Collections.Generic;

namespace LoanManagementSys.Managers
{
    /// <summary>
    /// Generic manager which allows other managers to inherit a generic list and ID if a number ID needs to be generated
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseManager<T>
    {
        public List<T> _systemItems = new List<T>(); //Generic list inherited by all managers to hold their objects
        public int _lastID = 100; //ID used for managers needing to generate a number ID
    }
}

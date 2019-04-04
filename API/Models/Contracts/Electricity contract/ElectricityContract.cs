﻿using API.Models.Electricity_contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ElectricityContract : Contract
    {
        private BuildingType buildingType;

        public ElectricityContract(int id, string name, double price, BuildingType buildingType) : base(id, name, price)
        {
            this.BuildingType = buildingType;
        }

        public BuildingType BuildingType
        {
            get => buildingType;

            set
            {
                try
                {
                    buildingType = value;
                }
                catch(ArgumentException e)
                {
                    throw new ArgumentException("Your building type does not exist.", e);
                }
            }
        }
    }
}
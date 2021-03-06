﻿using System;
using System.Collections.Generic;
using System.Text;
using eTicketStatus = Ex03.GarageLogic.Garage.eTicketStatus;

namespace Ex03.GarageLogic
{
    public class GarageTicket
    {
        private readonly string r_OwnerName;
        private readonly string r_OwnerPhoneNumber;
        private readonly string r_VehicleLicenseNumber;
        private eTicketStatus m_TicketStatus;

        public GarageTicket(string i_OwnerName, string i_OwnerPhoneNumber, string i_VehicleLicenseNumber)
        {
            r_OwnerName = i_OwnerName;
            r_OwnerPhoneNumber = i_OwnerPhoneNumber;
            r_VehicleLicenseNumber = i_VehicleLicenseNumber;
            m_TicketStatus = eTicketStatus.InProgress;
        }

        public eTicketStatus TicketStatus
        {
            get
            {
                return m_TicketStatus;
            }

            set
            {
                m_TicketStatus = value;
            }
        }

        public string VehicleLicenseNumber
        {
            get
            {
                return r_VehicleLicenseNumber;
            }
        }

        public string OwnerName
        {
            get
            {
                return r_OwnerName;
            }
        }

        public string OwnerPhoneNumber
        {
            get
            {
                return r_OwnerPhoneNumber;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class GarageTicket
    {
        internal enum eTicketStatus
        {
            InProgress,Ready,Paid
        }
        private readonly string r_OwnerName;
        private readonly string r_OwnerPhoneNumber;
        private readonly string r_VehicleLicenseNumber;
        private eTicketStatus m_ticketStatus = eTicketStatus.InProgress;

        public GarageTicket(string i_OwnerName, string i_OwnerPhoneNumber, string i_VehicleLicenseNumber)
        {
            r_OwnerName = i_OwnerName;
            r_OwnerPhoneNumber = i_OwnerPhoneNumber;
            r_VehicleLicenseNumber = i_VehicleLicenseNumber;
        }

        public eTicketStatus TicketStatus
        {
            get
            {
                return m_ticketStatus;
            }
            set
            {
                m_ticketStatus = value;
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
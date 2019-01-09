﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASR_App
{
    class Staff : User
    {
        const int MAXSLOTS = 4;
        public int SlotCounter { get; set; } = 0;
        public Staff(string id, string name, string email) : base(id, name, email) { }

        // Add counter everytime staff creates new slot
        public void AddSlot()
        {
            if(SlotCounter < MAXSLOTS)
            {
                SlotCounter++;
            }
            else
            {
                throw new SlotException("Unable to create slot.");
            }
           
        }

        // Reduce counter everytime staff deletes new slot
        public void DeleteSlot()
        {
            if (SlotCounter > 0 && SlotCounter <= MAXSLOTS)
            {
                SlotCounter--;
            }
            else
            {
                throw new SlotException("Maximum 4 slots");
            }

        }

    }

    
}

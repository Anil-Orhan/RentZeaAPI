﻿using System;
using Core.Abstract;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {

        public int RentalID { get; set; }
        public string BrandName { get; set; } 
        public string FullName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }



    }
}
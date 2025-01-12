﻿namespace MST_Service.ViewModels
{
    public class AddressViewModel
    {
        public Guid Id { get; set; }

        public string City { get; set; } = null!;

        public string District { get; set; } = null!;

        public string Street { get; set; } = null!;

        public string? ApartmentNumber { get; set; }

    }
}

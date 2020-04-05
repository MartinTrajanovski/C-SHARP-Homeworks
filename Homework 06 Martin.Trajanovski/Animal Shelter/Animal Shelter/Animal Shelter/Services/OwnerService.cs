using Animal_Shelter.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Shelter.Services
{
    public class OwnerService
    {
        public Owner[] Owners { get; set; }
        private HelperService helperService = new HelperService();
        public OwnerService()
        {
            Owners = new Owner[]
            {
                new Owner()
                {
                    FirstName = "Jovo",
                    LastName = "Jovev",
                    Address = "Kosta Abrasevic",
                    Age = 18,
                    City = "Skopje",
                }
            };
        }
        public Owner Register(Owner user)
        {
            if (!helperService.ValidateStringLength(user.FirstName, 2) || !helperService.ValidateStringLength(user.LastName, 2) ||
                !helperService.ValidateStringLength(user.Address, 3))
            {
                return null;
            }
            else
            {
                Owner[] newArray = Owners;
                Array.Resize(ref newArray, newArray.Length + 1);
                newArray[newArray.Length - 1] = user;
                Owners = newArray;
                return Owners[Owners.Length - 1];
            }

        }
    }
}

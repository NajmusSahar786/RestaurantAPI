using IRepositories;
using IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class OwnerService : IOwnerService
    {
        private IOwnerRepository _ownerRepository;
        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }
    }
}

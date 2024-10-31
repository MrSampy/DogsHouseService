﻿using Services.Abstractions.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions.Interfaces
{
    public interface ICacheService
    {
        List<DogDTO>? Get(string key);
        void Set(string key, List<DogDTO> dogs);
        void Reset();
    }
}

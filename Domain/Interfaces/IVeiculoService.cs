﻿using Domain.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IVeiculoService
    {
        Task PostAsync(VeiculoCommand command);

        void PostAsync();

        void GetAsync();
    }
}
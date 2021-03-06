﻿using AutoMapper;
using DddSuper.Aplication.Models;
using DddSuper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DddSuper.Aplication.Mapping
{
    public class ContaCorrenteProfile : Profile
    {
        public ContaCorrenteProfile()
        {
            CreateMap<ContaCorrente, ContaCorrenteModel>();
            CreateMap<ContaCorrenteModel, ContaCorrente>();
        }
    }
}

﻿using AutoMapper;
using MongoDB.Bson;
using Revisao.Data.ProvidersMongo.MongoDB.Colections;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.AutoMapper
{
	public class DomainToCollection : Profile
	{
		public DomainToCollection()
		{
			CreateMap<RegistroJogo, RegistroJogoCollection>();

		}
	}
}
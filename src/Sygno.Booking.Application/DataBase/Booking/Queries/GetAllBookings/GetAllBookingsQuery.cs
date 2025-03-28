﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygno.Booking.Application.DataBase.Booking.Queries.GetAllBookings
{
    public class GetAllBookingsQuery: IGetAllBookingsQuery
	{
		private readonly IDataBaseService _dataBaseService;

		public GetAllBookingsQuery(IDataBaseService dataBaseService)
		{
			_dataBaseService = dataBaseService;
		}

		public async Task<List<GetAllBookingsModel>> Execute()
		{
			var result = await (from booking in _dataBaseService.Booking
								join customer in _dataBaseService.Customer
								on booking.CustomerId equals customer.CustomerId
								select new GetAllBookingsModel
								{
									BookingId = booking.BookingId,
									Code = booking.Code,
									RegisterDate = booking.RegisterDate,
									Type = booking.Type,
									CustomerFullName = customer.FullName,
									CustomerDocumentNumber = customer.DocumentNumber
								}).ToListAsync();

			return result;
		}
	}
}

﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PRN_BE.Data;
using PRN_BE.Data.Constants;
using PRN_BE.Models.Request;
using PRN_BE.Models.Response;

namespace PRN_BE.Repositories.impl
{

    public class Booking_StatusRepository : IBooking_StatusRepository
    {
        private readonly EasyBookingBEContext _context;
        private readonly IMapper _mapper;

        public Booking_StatusRepository(EasyBookingBEContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BaseDataResponse<List<Booking_StatusModel>>> GetAllBooking_Status()
        {
            var bs = await _context.Booking_Status!.ToListAsync();
            var mappedData = _mapper.Map<List<Booking_StatusModel>>(bs);
            return new BaseDataResponse<List<Booking_StatusModel>>
            (
                statusCode: mappedData.Any() ? 200 : 404,
                message: mappedData.Any() ? Constants.SUCCESSFUL : Constants.NOT_FOUND,
                data: mappedData.Any() ? mappedData : new List<Booking_StatusModel>()
            );
        }

        public async Task<BaseDataResponse<Booking_StatusModel>> GetBooking_StatusById(int id)
        {
            var bs = await _context.Booking_Status!.FindAsync(id);
            return new BaseDataResponse<Booking_StatusModel>(
                statusCode: bs != null ? 200 : 404,
                message: bs != null ? Constants.SUCCESSFUL : Constants.NOT_FOUND,
                data: bs != null ? _mapper.Map<Booking_StatusModel>(bs) : null
            );
        }

        public async Task<BaseDataResponse<object>> CreateBooking_Status(Booking_StatusModel booking_status)
        {
            try
            {
                var exist = await _context.Booking_Status!.FirstOrDefaultAsync(bs =>
                    bs.booking_status_name == booking_status.booking_status_name);
                if (exist != null)
                {
                    return new BaseDataResponse<object>(
                        statusCode: 200,
                        message: Constants.ALREADY_EXSIST
                    );
                }

                var newBS = _mapper.Map<Booking_Status>(booking_status);
                _context.Booking_Status.Add(newBS);
                await _context.SaveChangesAsync();
                return new BaseDataResponse<object>(
                    statusCode: 200,
                    message: Constants.SUCCESSFUL,
                    data: newBS
                );
            }
            catch (Exception ex)
            {
                return new BaseDataResponse<object>(
                    statusCode: 500,
                    message: Constants.ERROR
                );
            }
        }

        public async Task<BaseDataResponse<object>> UpdateBooking_Status(int id, Booking_StatusModel booking_status)
        {
            var updateBs = await _context.Booking_Status!.FindAsync(id);
            if (updateBs != null)
            {
                if (id == booking_status.booking_status_id)
                {
                    var existBS = await _context.Booking_Status.FirstOrDefaultAsync(bs =>
                        bs.booking_status_name == booking_status.booking_status_name && bs.booking_status_id != id);
                    if (existBS != null)
                    {
                        return new BaseDataResponse<object>(
                            statusCode: 200,
                            message: Constants.ALREADY_EXSIST
                        );
                    }

                    updateBs.booking_status_name = booking_status.booking_status_name;
                    _context.Booking_Status!.Update(updateBs);
                    await _context.SaveChangesAsync();
                    return new BaseDataResponse<object>(
                        statusCode: 200,
                        message: Constants.SUCCESSFUL,
                        data: updateBs
                    );
                }

                return new BaseDataResponse<object>(
                    statusCode: 200,
                    message: Constants.NOT_MATCH
                );
            }

            return new BaseDataResponse<object>(
                statusCode: 404,
                message: Constants.NOT_FOUND
            );
        }

        public async Task<BaseDataResponse<object>> DeleteBooking_Status(int id)
        {
            var bs = await _context.Booking_Status!.FirstOrDefaultAsync(bs =>
                bs.booking_status_id == id);
            if (bs != null)
            {
                _context.Booking_Status!.Remove(bs);
                await _context.SaveChangesAsync();
                return new BaseDataResponse<object>(
                    statusCode: 200,
                    message: Constants.SUCCESSFUL
                );
            }

            return new BaseDataResponse<object>(
                statusCode: 404,
                message: Constants.NOT_FOUND
            );
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMD.Appointment.Domain.Entities;

namespace CMD.Appointment.Domain.IRepositories
{
    public interface IAppointmentRepo
    {
        public Task AddAppointment(AppointmentModel appointmentModel);
        public Task UpdateAppointment(AppointmentModel  appointmentModel);
        public Task<AppointmentModel> GetAppointmentById(int id);
        public Task<List<AppointmentModel>> GetAllAppointments(int pageNumber , int pageSize);
        public Task<List<AppointmentModel>> GetActiveAppointments(int pageNumber, int pageSize);
        public Task<List<AppointmentModel>> GetInactiveAppointments(int pageNumber, int pageSize);
        public Task<List<AppointmentModel>> FilterAppointmentsByDate(DateOnly date);
        public Task<List<AppointmentModel>> FilterAppointmentsByStatus(string status);
        public Task CancelAppointment(int id);
    }
}

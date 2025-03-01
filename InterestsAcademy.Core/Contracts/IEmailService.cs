﻿using InterestsAcademy.Core.Models.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface IEmailService
    {
        Task SendEmailAsync(SendMessageQueryModel email);
    }
}

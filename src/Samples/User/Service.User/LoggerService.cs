﻿using IService.User;
using Jimu.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.User
{
    public class LoggerService : ILoggerService
    {
        readonly ILogger _logger;
        public LoggerService(ILogger logger)
        {
            _logger = logger;
        }
        public void Post(string log)
        {
            _logger.Debug(log);// will log in the folder log where in the root path of this server
        }
    }
}

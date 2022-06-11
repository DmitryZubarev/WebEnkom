﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebEnkom.Domain.Enum;

namespace WebEnkom.Domain.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Description { get; set; }

        public StatusCode StatusCode { get; set; }

        public T Data { get; }
    }

    public interface IBaseResponse <T>
    {
        T Data { get; }
    }
}

﻿using Abp.Application.Services;
using BlazorProject.Backend.UserAddresses.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.UserAddresses
{
    public interface IUserAddressService: IAsyncCrudAppService<UserAddressDto,int,CreateUserAddressDto,PagedUserAddressResultRequestDto,UserAddressDto>
    {
        Task<UserAddressDto> GetByUserId(long id);
    }
}

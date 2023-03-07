﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BryanCalderon.ArqLimpia.BL.DTOs.UserDTOs;

namespace BryanCalderon.ArqLimpia.BL.Interfaces
{
    public interface IUserBL
    {
        Task<CreateUserOutputDTO> Create(CreateUserInputDTO pUser);

        Task<int> Update(UpdateUserDTO pUser);

        Task<int> Delete(DeleteUserDTO pUser);

        Task<GetByIdUserOutputDTO> GetById(GetByIdUserInputDTO pUser);

        Task<List<SearchUserOutputDTO>> Search(SearchUserInputDTO pUser);
    }
}

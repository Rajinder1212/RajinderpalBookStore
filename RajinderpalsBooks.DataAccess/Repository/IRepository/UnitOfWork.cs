﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RajinderpalsBooks.DataAccess.Repository.IRepository
{
    interface UnitOfWork : IDisposable
    {
        ICategoryRepository Category { get;  }
        ISP_Call SP_Call { get;  }
    }
}

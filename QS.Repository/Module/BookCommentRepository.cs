﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QS.Core.IRepository;
using QS.Core.Module.CommentAggregate;
using QS.Core.Module.SharedAggregate;
using QS.DAL;

namespace QS.Repository.Module
{
    public class BookCommentRepository : Repository<BookComment>, IBookCommentRepository
    {
        public BookCommentRepository(UnitOfWork unitOfWork)
            :base(unitOfWork)
        {
            
        }
    }
}
